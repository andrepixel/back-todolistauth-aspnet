using back_todolistauth_aspnet.src.Infrastructure.Configurations.Mappers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddSingleton<IUserRepository, UserRepository>();

builder.Services.AddAutoMapper(typeof(ItemListMapper));

app.Run();
