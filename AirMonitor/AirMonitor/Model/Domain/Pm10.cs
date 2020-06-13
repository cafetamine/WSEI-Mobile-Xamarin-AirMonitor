namespace AirMonitor.Model.Domain
{
    public class Pm10
    {
        private const int DefaultValue = 34;
        private const int DefaultPercent = 137;
        
        private int _value = 67;
        private int _percent = 135;
        
        public int Value
        {
            get => _value;
            set => _value = value;
        }

        public int Percent
        {
            get => _percent;
            set => _percent =value;
        }

        private Pm10(int value, int percent)
        {
            _value = value;
            _percent = percent;
        }

        public static Pm10 Default() => new Pm10(DefaultValue, DefaultPercent);
        
        public static Pm10 Create(int value, int percent) => new Pm10(value, percent);
    }
}