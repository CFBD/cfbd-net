# Error Handling Guide

Best practices for handling errors when using the CollegeFootballData.NET library.

## Common HTTP Status Codes

| Status Code | Meaning | Typical Cause | Solution |
|-------------|---------|---------------|----------|
| 400 | Bad Request | Invalid parameters | Check parameter values and types |
| 401 | Unauthorized | Invalid/missing API key | Verify API key and authentication setup |
| 403 | Forbidden | Monthly limit exceeded | Check monthly usage or upgrade subscription |
| 404 | Not Found | Invalid endpoint/resource | Verify endpoint URL and parameters |
| 500 | Server Error | API server issue | Retry after delay |

**Note**: The API uses monthly call limits rather than rate limiting (429 errors).

## Basic Error Handling

### Try-Catch Pattern

**Important**: All API calls require authentication.

```csharp
// Setup authentication first (required for all calls)
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required");

var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
var client = new ApiClient(requestAdapter);

try
{
    var games = await client.Games.GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Year = 2023;
    });
}
catch (HttpRequestException ex)
{
    Console.WriteLine($"HTTP error: {ex.Message}");
    // Handle HTTP-specific errors
}
catch (TaskCanceledException ex)
{
    Console.WriteLine($"Request timeout: {ex.Message}");
    // Handle timeout scenarios
}
catch (Exception ex)
{
    Console.WriteLine($"Unexpected error: {ex.Message}");
    // Handle any other errors
}
```

## Advanced Error Handling

### Retry Logic for Server Errors

```csharp
public async Task<T> RetryApiCall<T>(Func<Task<T>> apiCall, int maxRetries = 3)
{
    var retryDelay = TimeSpan.FromSeconds(1);
    
    for (int attempt = 1; attempt <= maxRetries; attempt++)
    {
        try
        {
            return await apiCall();
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("403") && attempt < maxRetries)
        {
            Console.WriteLine($"Monthly limit may be exceeded. Retrying in {retryDelay.TotalSeconds} seconds...");
            await Task.Delay(retryDelay);
            retryDelay = TimeSpan.FromMilliseconds(retryDelay.TotalMilliseconds * 2); // Exponential backoff
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("5") && attempt < maxRetries)
        {
            Console.WriteLine($"Server error. Retrying in {retryDelay.TotalSeconds} seconds...");
            await Task.Delay(retryDelay);
        }
    }
    
    throw new InvalidOperationException($"Failed after {maxRetries} attempts");
}
```

### Custom Exception Types

```csharp
public class CollegeFootballDataException : Exception
{
    public int? StatusCode { get; }
    
    public CollegeFootballDataException(string message, int? statusCode = null) 
        : base(message)
    {
        StatusCode = statusCode;
    }
}

public class MonthlyLimitExceededException : CollegeFootballDataException
{
    public int MonthlyLimit { get; }
    
    public MonthlyLimitExceededException(int monthlyLimit) 
        : base($"Monthly API limit of {monthlyLimit} calls exceeded")
    {
        MonthlyLimit = monthlyLimit;
    }
}

public class AuthenticationRequiredException : CollegeFootballDataException
{
    public AuthenticationRequiredException() 
        : base("API key is required for all API calls")
    {
    }
}
```

## Validation and Data Checking

### Parameter Validation

```csharp
public async Task<List<Game>> GetGamesWithValidation(int year, string team = null)
{
    // Validate year range
    if (year < 2000 || year > DateTime.Now.Year + 1)
    {
        throw new ArgumentException($"Year {year} is outside valid range (2000-{DateTime.Now.Year + 1})");
    }
    
    // Validate team name format
    if (!string.IsNullOrEmpty(team) && team.Length < 2)
    {
        throw new ArgumentException("Team name must be at least 2 characters");
    }
    
    return await client.Games.GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Year = year;
        if (!string.IsNullOrEmpty(team))
        {
            requestConfiguration.QueryParameters.Team = team;
        }
    });
}
```

### Response Validation

```csharp
public async Task<List<Game>> GetValidatedGames(int year)
{
    var games = await client.Games.GetAsync(requestConfiguration =>
    {
        requestConfiguration.QueryParameters.Year = year;
    });
    
    if (games == null)
    {
        throw new InvalidOperationException("API returned null response");
    }
    
    if (!games.Any())
    {
        Console.WriteLine($"Warning: No games found for year {year}");
    }
    
    // Filter out invalid games
    var validGames = games.Where(g => 
        !string.IsNullOrEmpty(g.HomeTeam) && 
        !string.IsNullOrEmpty(g.AwayTeam) &&
        g.Season == year
    ).ToList();
    
    if (validGames.Count != games.Count)
    {
        Console.WriteLine($"Warning: Filtered out {games.Count - validGames.Count} invalid games");
    }
    
    return validGames;
}
```

## Logging Integration

### Using ILogger

```csharp
public class CollegeFootballService
{
    private readonly ApiClient _client;
    private readonly ILogger<CollegeFootballService> _logger;

    public CollegeFootballService(ApiClient client, ILogger<CollegeFootballService> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<List<Game>> GetGamesWithLogging(int year)
    {
        _logger.LogInformation("Requesting games for year {Year}", year);
        
        try
        {
            var games = await _client.Games.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Year = year;
            });
            
            _logger.LogInformation("Successfully retrieved {Count} games for year {Year}", 
                games.Count, year);
            
            return games;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogError(ex, "HTTP error while retrieving games for year {Year}", year);
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error while retrieving games for year {Year}", year);
            throw;
        }
    }
}
```

## Circuit Breaker Pattern

```csharp
public class CircuitBreakerApiClient
{
    private readonly ApiClient _client;
    private int _failureCount = 0;
    private DateTime _lastFailureTime = DateTime.MinValue;
    private readonly int _failureThreshold = 5;
    private readonly TimeSpan _timeout = TimeSpan.FromMinutes(5);

    public async Task<T> ExecuteWithCircuitBreaker<T>(Func<Task<T>> operation)
    {
        if (_failureCount >= _failureThreshold)
        {
            if (DateTime.UtcNow - _lastFailureTime < _timeout)
            {
                throw new InvalidOperationException("Circuit breaker is open");
            }
            else
            {
                // Reset circuit breaker
                _failureCount = 0;
            }
        }

        try
        {
            var result = await operation();
            _failureCount = 0; // Reset on success
            return result;
        }
        catch (Exception)
        {
            _failureCount++;
            _lastFailureTime = DateTime.UtcNow;
            throw;
        }
    }
}
```

## Best Practices Summary

1. **Always use try-catch blocks** for API calls
2. **Implement retry logic** for transient failures
3. **Validate input parameters** before making API calls
4. **Check response data** for null/invalid values
5. **Use appropriate logging** for debugging and monitoring
6. **Handle rate limiting** gracefully with exponential backoff
7. **Consider circuit breaker patterns** for resilient applications
8. **Test error scenarios** during development