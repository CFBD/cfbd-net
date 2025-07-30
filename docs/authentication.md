# Authentication Guide

Learn how to authenticate with the CollegeFootballData.com API. **Authentication is required for all API calls.**

## API Tiers

The CollegeFootballData.com API offers subscription tiers based on monthly call limits:

### Free Tier
- **Monthly Limit**: 1,000 API calls per month
- **Data**: All historical data
- **Authentication**: API key required
- **Cost**: Free (requires API key registration)

### Premium Tiers
- **Monthly Limits**: Higher limits based on Patreon support level
- **Data**: All historical data plus priority support
- **Authentication**: API key required
- **Cost**: Subscription-based through Patreon

**Important**: Unlike rate limiting (requests per minute/hour), the API uses monthly call limits. Once you reach your monthly limit, you'll need to wait until the next month or upgrade your tier.

## Getting an API Key

1. Visit [CollegeFootballData.com](https://collegefootballdata.com)
2. Create an account or sign in
3. Navigate to your account settings
4. Generate an API key
5. Choose your subscription plan (free tier available)

## Proper Authentication Implementation

The API requires Bearer token authentication with all requests. Here's the correct way to implement it:

### Required Imports

```csharp
using CollegeFootballData;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
```

### Basic Authentication Setup

```csharp
// Get API key from environment variable
string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY") 
    ?? throw new InvalidOperationException("API key is required for all API calls");

// Create authentication provider with Bearer token
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));

// Create HTTP client and request adapter with authentication
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);

// Create the API client
var client = new ApiClient(requestAdapter);
```

### Access Token Provider Implementation

You need to implement the `IAccessTokenProvider` interface:

```csharp
public class StaticAccessTokenProvider : IAccessTokenProvider
{
    private readonly string _token;

    public StaticAccessTokenProvider(string token)
    {
        _token = token ?? throw new ArgumentNullException(nameof(token));
    }

    public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(_token);
    }

    public AllowedHostsValidator AllowedHostsValidator { get; } = new AllowedHostsValidator();
}
```

### Complete Working Example

```csharp
using CollegeFootballData;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

class Program
{
    static async Task Main(string[] args)
    {
        // Get API key
        string apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY");
        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Please set COLLEGE_FOOTBALL_API_KEY environment variable");
            return;
        }

        // Setup authentication
        var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
        var httpClient = new HttpClient();
        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

        try
        {
            // Make API call
            var games = await client.Games.GetAsync(requestConfiguration =>
            {
                requestConfiguration.QueryParameters.Year = 2023;
                requestConfiguration.QueryParameters.Week = 1;
            });

            Console.WriteLine($"Found {games.Count} games");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
```

### Environment Variables

Store your API key securely using environment variables:

```csharp
var apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY");

if (string.IsNullOrEmpty(apiKey))
{
    throw new InvalidOperationException("COLLEGE_FOOTBALL_API_KEY environment variable must be set");
}

var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
var httpClient = new HttpClient();
var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
var client = new ApiClient(requestAdapter);
```

### Configuration Files

For applications, use configuration files:

**appsettings.json**
```json
{
  "CollegeFootballData": {
    "ApiKey": "your-api-key-here",
    "BaseUrl": "https://api.collegefootballdata.com"
  }
}
```

**Usage in code**
```csharp
public class CollegeFootballService
{
    private readonly ApiClient _client;

    public CollegeFootballService(IConfiguration configuration)
    {
        var apiKey = configuration["CollegeFootballData:ApiKey"];
        
        if (string.IsNullOrEmpty(apiKey))
        {
            throw new InvalidOperationException("API key is required for all API calls");
        }

        var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
        var httpClient = new HttpClient();
        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        _client = new ApiClient(requestAdapter);
    }
}
```

## Dependency Injection Setup

For ASP.NET Core applications:

**Program.cs**
```csharp
var builder = WebApplication.CreateBuilder(args);

// Register the access token provider
builder.Services.AddSingleton<IAccessTokenProvider>(provider =>
{
    var configuration = provider.GetRequiredService<IConfiguration>();
    var apiKey = configuration["CollegeFootballData:ApiKey"];
    
    if (string.IsNullOrEmpty(apiKey))
    {
        throw new InvalidOperationException("API key is required");
    }
    
    return new StaticAccessTokenProvider(apiKey);
});

// Register the authentication provider
builder.Services.AddSingleton<IAuthenticationProvider>(provider =>
{
    var tokenProvider = provider.GetRequiredService<IAccessTokenProvider>();
    return new BaseBearerTokenAuthenticationProvider(tokenProvider);
});

// Configure HTTP client with authentication
builder.Services.AddHttpClient<ApiClient>();

// Register the request adapter and API client
builder.Services.AddScoped<IRequestAdapter>(provider =>
{
    var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
    var httpClient = httpClientFactory.CreateClient(nameof(ApiClient));
    var authProvider = provider.GetRequiredService<IAuthenticationProvider>();
    return new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
});

builder.Services.AddScoped<ApiClient>();

var app = builder.Build();
```

**Usage in Controller**
```csharp
[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    private readonly ApiClient _cfbdClient;

    public GamesController(ApiClient cfbdClient)
    {
        _cfbdClient = cfbdClient;
    }

    [HttpGet]
    public async Task<IActionResult> GetGames(int year)
    {
        var games = await _cfbdClient.Games.GetAsync(config =>
        {
            config.QueryParameters.Year = year;
        });

        return Ok(games);
    }
}
```

## Security Best Practices

### 1. Never Hardcode API Keys

```csharp
// ❌ Bad - Don't do this
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider("abc123def456"));

// ✅ Good - Use environment variables or configuration
var apiKey = Environment.GetEnvironmentVariable("COLLEGE_FOOTBALL_API_KEY");
var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
```

### 2. Use Secret Management

For development, use .NET's Secret Manager:

```bash
# Initialize secret storage
dotnet user-secrets init

# Set your API key
dotnet user-secrets set "CollegeFootballData:ApiKey" "your-api-key-here"
```

### 3. Production Secrets

In production, use:
- Azure Key Vault
- AWS Secrets Manager
- Environment variables
- Kubernetes secrets

### 4. Validate API Keys

```csharp
public static async Task<bool> ValidateApiKey(string apiKey)
{
    try
    {
        var authProvider = new BaseBearerTokenAuthenticationProvider(new StaticAccessTokenProvider(apiKey));
        var httpClient = new HttpClient();
        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

        // Make a simple request to validate the key
        var teams = await client.Teams.GetAsync();
        return teams != null;
    }
    catch
    {
        return false;
    }
}
```

## Monthly Call Limits

### Understanding Limits

The API uses monthly call limits rather than rate limiting:

- **Free Tier**: 1,000 calls per month
- **Premium Tiers**: Higher monthly limits based on subscription level

### Monitoring Usage

Track your API usage to stay within limits:

```csharp
public class ApiUsageTracker
{
    private int _callsThisMonth = 0;
    private readonly int _monthlyLimit;

    public ApiUsageTracker(int monthlyLimit)
    {
        _monthlyLimit = monthlyLimit;
    }

    public async Task<T> ExecuteWithTracking<T>(Func<Task<T>> apiCall)
    {
        if (_callsThisMonth >= _monthlyLimit)
        {
            throw new InvalidOperationException($"Monthly API limit of {_monthlyLimit} calls exceeded");
        }

        var result = await apiCall();
        _callsThisMonth++;
        
        Console.WriteLine($"API calls this month: {_callsThisMonth}/{_monthlyLimit}");
        
        return result;
    }
}
```

## Troubleshooting Authentication

### Common Issues

1. **401 Unauthorized**
   - Check that your API key is correct
   - Verify you're using the proper Bearer token authentication
   - Ensure your subscription is active

2. **403 Forbidden**
   - You may have exceeded your monthly call limit
   - Check your subscription level
   - Verify endpoint permissions

3. **Missing Authentication**
   - All API calls require authentication
   - Ensure you're using `BaseBearerTokenAuthenticationProvider`
   - Verify the `IAccessTokenProvider` implementation

### Debug Authentication

```csharp
public class AuthenticatedApiClient
{
    private readonly ApiClient _client;
    private readonly ILogger<AuthenticatedApiClient> _logger;

    public AuthenticatedApiClient(ApiClient client, ILogger<AuthenticatedApiClient> logger)
    {
        _client = client;
        _logger = logger;
    }

    public async Task<List<Game>> GetGamesWithLogging(int year)
    {
        try
        {
            _logger.LogInformation("Requesting games for year {Year}", year);
            
            var games = await _client.Games.GetAsync(config =>
            {
                config.QueryParameters.Year = year;
            });

            _logger.LogInformation("Successfully retrieved {Count} games", games.Count);
            return games;
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("401"))
        {
            _logger.LogError("Authentication failed: {Message}. Check your API key.", ex.Message);
            throw new UnauthorizedAccessException("Invalid API key", ex);
        }
        catch (HttpRequestException ex) when (ex.Message.Contains("403"))
        {
            _logger.LogError("Access forbidden: {Message}. Check monthly limits.", ex.Message);
            throw new UnauthorizedAccessException("Monthly limit exceeded or subscription required", ex);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unexpected error getting games");
            throw;
        }
    }
}
```

## Next Steps

- Review the [Getting Started](getting-started.md) guide
- Explore [Examples](examples.md) with proper authentication
- Check out [Error Handling](error-handling.md) for authentication errors
- Browse the API documentation for all available endpoints