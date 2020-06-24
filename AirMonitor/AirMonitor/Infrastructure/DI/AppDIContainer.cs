using System;
using AirMonitor.Client.Airly;
using AirMonitor.Client.Airly.Mock;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Application.Location;
using AirMonitor.Core.Application.Measurement.Repository;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Application.Measurement.Service;
using AirMonitor.Infrastructure.Location;
using AirMonitor.Infrastructure.Measurement;
using AirMonitor.Infrastructure.Persistence;
using AirMonitor.Persistence.Measurement;
using AirMonitor.Persistence.Measurement.Installation;
using AirMonitor.Persistence.Measurement.Installation.Address;
using AirMonitor.Persistence.Measurement.Installation.Loaction;
using AirMonitor.Persistence.Measurement.Installation.Sponsor;
using AirMonitor.Persistence.Measurement.Item;
using AirMonitor.Persistence.Measurement.Item.AirQuality;
using AirMonitor.Persistence.Measurement.Item.Value;
using AirMonitor.Persistence.Utility;
using AirMonitor.Profile;
using Autofac;

namespace AirMonitor.Infrastructure.DI
{
    public class AppDIContainer
    {
        private static readonly AppDIContainer _instance = new AppDIContainer();
        public static AppDIContainer Instance => _instance;

        private IContainer _container;
        private ContainerBuilder _builder;

        private AppDIContainer()
        {
            _builder = new ContainerBuilder();
        }

        public void InitializeWithAppProfile(IAppProfile appProfile)
        {
            // Configurations
            _builder.Register(component => appProfile).As<IAppProfile>().SingleInstance();
            
            // Database
            _builder.RegisterType<DbConnection>().As<IDbConnection>().SingleInstance();
            _builder.RegisterType<DbInitializer>().As<IDbInitializer>().SingleInstance();
            
            // Installation repositories
            _builder.RegisterType<AddressRepository>().As<IAddressRepository>().SingleInstance();
            _builder.RegisterType<LocationRepository>().As<ILocationRepository>().SingleInstance();
            _builder.RegisterType<SponsorRepository>().As<ISponsorRepository>().SingleInstance();
            _builder.RegisterType<InstallationRepository>().As<IInstallationRepository>().SingleInstance();
            
            // Measurement repositories
            _builder.RegisterType<AirQualityIndexRepository>().As<IAirQualityIndexRepository>().SingleInstance();
            _builder.RegisterType<AirQualityStandardRepository>().As<IAirQualityStandardRepository>().SingleInstance();
            _builder.RegisterType<MeasurementValueRepository>().As<IMeasurementItemValueRepository>().SingleInstance();
            _builder.RegisterType<MeasurementItemRepository>().As<IMeasurementItemRepository>().SingleInstance();
            _builder.RegisterType<MeasurementRepository>().As<IMeasurementRepository>().SingleInstance();
            

            // Clients
//            _builder.Register(component => CreateAirlyClient(appProfile)).As<IAirlyClient>().SingleInstance();
            _builder.RegisterType<AirlyMockedClient>().As<IAirlyClient>().SingleInstance();

            // Services
            _builder.RegisterType<LocationService>().As<ILocationService>().SingleInstance();
            _builder.RegisterType<MeasurementsService>().As<IMeasurementsService>().SingleInstance();

            _container = _builder.Build();
        }
        
        public T Resolve<T>() => _container.Resolve<T>();

        public object Resolve(Type type) => _container.Resolve(type);

        private static IAirlyClient CreateAirlyClient(IAppProfile appProfile)
            => AirlyClientFactory.CreateClient(appProfile.ClientConfiguration.AirlyClientConfiguration);
    }
}
