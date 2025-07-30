# Talent API

Team talent ratings and composite scores.

## Endpoint

`/talent`

## Usage

```csharp
var talent = await client.Talent.GetAsync(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Year = 2023;
});
```

## Query Parameters

| Parameter | Type | Required | Description |
|-----------|------|----------|-------------|
| `year` | int | No | Season year |

## Response Properties

| Property | Type | Description |
|----------|------|-------------|
| `Year` | int? | Season year |
| `School` | string? | School name |
| `Talent` | double? | Composite talent rating |

## Use Cases

1. **Talent Evaluation**: Compare talent levels across teams
2. **Recruiting Success**: Measure recruiting effectiveness over time
3. **Competitive Balance**: Analyze talent distribution in conferences
4. **Expectation Setting**: Use talent as baseline for team expectations