﻿using System;
using Autofac;
using StockApp.Contracts.Services;
using StockApp.Services;
using StockApp.ViewModels;

namespace StockApp.Bootstrap
{
    public static class AppContainer
    {
        private static IContainer _container;

        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            //ViewModels
            builder.RegisterType<MainPageViewModel>();
            //Services
            builder.RegisterType<StockDataService>().As<IStockDataService>();


            _container = builder.Build();
        }

        public static object Resolve (Type typeName)
        {
            return _container.Resolve(typeName);
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }
    }
}
