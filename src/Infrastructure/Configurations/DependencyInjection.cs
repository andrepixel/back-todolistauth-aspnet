using Microsoft.EntityFrameworkCore;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionDatabase"))
                );

            services.AddScoped<IListRepository, ListRepository>();
            services.AddScoped<IItensListRepository, ItensListRepository>();
        }

        return services;
    }

    public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
    {
        {
            services.AddScoped<ListApplicationService>();
            services.AddScoped<ItensListApplicationService>();
            services.AddScoped<CreateItemListUsecase>();
            services.AddScoped<DeleteItemListUsecase>();
            services.AddScoped<FindItemListUsecase>();
            services.AddScoped<GetItensListUsecase>();
            services.AddScoped<UpdateItemListUsecase>();
            services.AddScoped<CreateListsUsecase>();
            services.AddScoped<DeleteListsUsecase>();
            services.AddScoped<FindListUsecase>();
            services.AddScoped<GetListsUsecase>();
            services.AddScoped<UpdateListsUsecase>();
        }

        return services;
    }
}