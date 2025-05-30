﻿using Api.Contexts;
using Api.Repositories.Implementations;
using Api.Repositories.Interfaces;
using Infraestrutura.Controllers;
using Infraestrutura.Selenium;

namespace Api.Configurations;

public static class DependencyInjectionConfiguration
{
    public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
    {
        services.AddScoped<IResponseControler, ResponseControler>();
        services.AddDbContext<PostgresDbContext>();
        services.AddScoped<SeleniumBase>();

        services.AddScoped<IAnuncioRepository, AnuncioRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
        services.AddScoped<IImagesPostRepository, ImagesPostRepository>();
        return services;
    }
}
