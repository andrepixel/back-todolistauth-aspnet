using back_todolistauth_aspnet.src.Infrastructure.Configurations.Mappers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddApplicationPart(typeof(ListController).Assembly)
    .AddControllersAsServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(typeof(ItemListMapper));
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication(builder.Configuration);

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseAuthorization();
app.MapControllers();
app.Run();
