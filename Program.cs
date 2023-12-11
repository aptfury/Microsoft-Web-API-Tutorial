using System.Text.Json.Serialization;

/* var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

var sampleTodos = new Todo[] {
    new(1, "Walk the dog"),
    new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
    new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
    new(4, "Clean the bathroom"),
    new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2)))
};

var todosApi = app.MapGroup("/todos");
todosApi.MapGet("/", () => sampleTodos);
todosApi.MapGet("/{id}", (int id) =>
    sampleTodos.FirstOrDefault(a => a.Id == id) is { } todo
        ? Results.Ok(todo)
        : Results.NotFound());

app.Run();

public record Todo(int Id, string? Title, DateOnly? DueBy = null, bool IsComplete = false);

[JsonSerializable(typeof(Todo[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{

} */

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => { });

var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseCors("some unique string as a test string");

/**
 * From Tutorial:
 * Middleware is usually code that intercepts the request and carries out checks like checking for authentication or ensuring the client is allowed
 * to perform this operation according to CORS. After the middleware is done executing, the actual request is carried out. Data is either read or
 * written to the store and a response is sent back to the calling client.
 */

app.Run();
