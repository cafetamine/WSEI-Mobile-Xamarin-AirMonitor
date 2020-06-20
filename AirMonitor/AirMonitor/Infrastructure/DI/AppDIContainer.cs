using System;
using AirMonitor.Client.Airly;
using AirMonitor.Client.Airly.Mock;
using AirMonitor.Core.Application.Installation;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Application.Location;
using AirMonitor.Core.Application.Measurement;
using AirMonitor.Core.Application.Measurement.Service;
using AirMonitor.Infrastructure.Location;
using AirMonitor.Infrastructure.Measurement;
using AirMonitor.Infrastructure.Persistence;
using AirMonitor.Persistence.Repository.Installation;
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

        private IAirlyClient _airlyClient;
        
        private AppDIContainer()
        {
            _builder = new ContainerBuilder();
        }

        public void InitializeWithAppProfile(IAppProfile appProfile)
        {
            // Configurations
            _builder.Register(component => appProfile).As<IAppProfile>().SingleInstance();
            
            // Database
            IDbConnection dbConnection = new DbConnection();
            IDbInitializer dbInitializer = new DbInitializer(dbConnection);
            _builder.Register(component => dbConnection).As<IDbConnection>().SingleInstance();
            _builder.Register(component => dbInitializer).As<IDbInitializer>().SingleInstance();
            
            // Repositories Installation
            IAddressRepository addressRepository = new AddressRepository(dbConnection);
            ILocationRepository locationRepository = new LocationRepository(dbConnection);
            ISponsorRepository sponsorRepository = new SponsorRepository(dbConnection);
            IInstallationRepository installationRepository = new InstallationRepository(dbConnection, addressRepository, locationRepository, sponsorRepository);
            _builder.Register(component => addressRepository).As<IAddressRepository>().SingleInstance();
            _builder.Register(component => locationRepository).As<ILocationRepository>().SingleInstance();
            _builder.Register(component => sponsorRepository).As<ISponsorRepository>().SingleInstance();
            _builder.Register(component => installationRepository).As<IInstallationRepository>().SingleInstance();

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
