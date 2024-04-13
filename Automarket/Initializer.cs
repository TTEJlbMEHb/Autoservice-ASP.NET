﻿using Automarket.DAL.Interfaces;
using Automarket.DAL.Repositories;
using Automarket.Domain.Entity;
using Automarket.Domain.Responce;
using Automarket.Service.Implementations;
using Automarket.Service.Interfaces;

namespace Automarket
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Car>, CarRepository>();
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Consumable>, ConsumableRepository>();
            services.AddScoped<IBaseRepository<Appointment>, AppointmentRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IConsumableService, ConsumableService>();
            services.AddScoped<IAutoServiceService, AutoServiceService>();
        }
    }
}