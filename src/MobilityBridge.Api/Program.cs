using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.ConfigureHttpJsonOptions(options =>
    options.SerializerOptions.Converters.Add(new JsonStringEnumConverter()));
builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();
app.MapOpenApi();
app.MapHealthChecks("/health/ready");
app.MapGet("/health/live", () => Results.Ok(new { status = "ok", service = "mobilitybridge-api" }));
app.Run();
