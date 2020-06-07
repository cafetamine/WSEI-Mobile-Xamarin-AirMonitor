using AirMonitor.Model;

namespace AirMonitor.ViewModels
{
    public class DetailsViewModel : AbstractViewModel
    {
        private Caqi _caqi;
        private Pm25 _pm25;
        private Pm10 _pm10;
        private Air _air;

        public Caqi Caqi
        {
            get => _caqi;
            set => SetProperty(ref _caqi, value);
        }

        public Pm25 Pm25
        {
            get => _pm25;
            set => SetProperty(ref _pm25, value);
        }
        
        public Pm10 Pm10
        {
            get => _pm10;
            set => SetProperty(ref _pm10, value);
        }
        
        public Air Air
        {
            get => _air;
            set => SetProperty(ref _air, value);
        }
        
        public DetailsViewModel()
        {
            _caqi = Caqi.Default();
            _pm25 = Pm25.Default();
            _pm10 = Pm10.Default();
            _air = Air.Default();
        }
    }
}
