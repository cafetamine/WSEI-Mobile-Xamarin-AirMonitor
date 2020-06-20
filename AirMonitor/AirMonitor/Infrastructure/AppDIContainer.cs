using System;
using AirMonitor.Client.Airly;
using AirMonitor.Profile;
using AirMonitor.Service.Location;
using AirMonitor.Service.Measurements;
using Autofac;

namespace AirMonitor.Infrastructure
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

            // Clients
            _builder.Register(component => CreateAirlyClient(appProfile)).As<IAirlyClient>();

            // Services
            _builder.RegisterType<LocationService>().As<ILocationService>();
            _builder.RegisterType<MeasurementsService>().As<IMeasurementsService>();

            _container = _builder.Build();
        }
        
        public T Resolve<T>() => _container.Resolve<T>();

        public object Resolve(Type type) => _container.Resolve(type);

        private static IAirlyClient CreateAirlyClient(IAppProfile appProfile)
            => AirlyClientFactory.CreateClient(appProfile.ClientConfiguration.AirlyClientConfiguration);
    }
}
