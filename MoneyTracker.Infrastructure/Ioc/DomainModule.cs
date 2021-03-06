﻿using Autofac;
using MoneyTracker.Domain.Core;
using MoneyTracker.Domain.ReadModel;
using MoneyTracker.Domain.SeedWork;
using MoneyTracker.Domain.WriteModel.BalanceAggregate;
using MoneyTracker.Infrastructure.Domain;
using MoneyTracker.Infrastructure.Domain.ReadModel;
using MoneyTracker.Infrastructure.Domain.WriteModel;
using MoneyTracker.Infrastructure.Persistence;

namespace MoneyTracker.Infrastructure.Ioc
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BalanceRepository>()
                .As<IBalanceRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<MoneyTrackerDbContext>()
                .AsSelf()
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>()
                .As<IUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BalanceDetailsProvider>()
                .As<IBalanceDetailsProvider>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CurrencyProvider>()
                .As<ICurrencyProvider>()
                .InstancePerLifetimeScope();
        }
    }
}
