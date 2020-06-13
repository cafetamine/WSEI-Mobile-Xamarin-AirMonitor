namespace AirMonitor.Model.Domain
{
    public class Air
    {
        private const double DefaultHumidity = 0.95;
        private const int DefaultPressure = 1027;
            
        private double _humidity;
        private int _pressure;
        
        public double Humidity
        {
            get => _humidity;
            set => _humidity = value;
        }

        public int Pressure
        {
            get => _pressure;
            set => _pressure =value;
        }

        private Air(double humidity, int pressure)
        {
            _humidity = humidity;
            _pressure = pressure;
        }
        
        public static Air Default() => new Air(DefaultHumidity, DefaultPressure);

        public static Air Create(double humidity, int pressure) => new Air(humidity, pressure);
    }
}