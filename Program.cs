var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSingleton<IUserRepository, UserRepository>();

app.MapGet("/", () => "Hello World!");

app.Run();
