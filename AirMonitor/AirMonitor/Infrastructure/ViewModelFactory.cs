using AirMonitor.Service.Location;
using AirMonitor.Service.Measurements;
using AirMonitor.ViewModels;
using Xamarin.Forms;

namespace AirMonitor.Infrastructure
{
    // TODO refactor <T> MakeFromType(<T>)
    public class ViewModelFactory
    {
        public static HomeViewModel MakeHomeViewModel(INavigation navigation)
            => new HomeViewModel(navigation:          navigation,
                                 measurementsService: AppDIContainer.Instance.Resolve<IMeasurementsService>(),
                                 locationService:     AppDIContainer.Instance.Resolve<ILocationService>());

        public static DetailsViewModel MakeDetailsViewModel() => new DetailsViewModel();
    }
}
