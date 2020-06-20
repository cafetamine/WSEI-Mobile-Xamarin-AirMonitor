namespace AirMonitor.Model.Domain
{
    public class Pm25
    {
        private const int DefaultValue = 34;
        private const int DefaultPercent = 137;

        private int _value;
        private int _percent;
        
        
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

        private Pm25(int value, int percent)
        {
            _value = value;
            _percent = percent;
        }

        public static Pm25 Default() => new Pm25(DefaultValue, DefaultPercent);
        
        public static Pm25 Create(int value, int percent) => new Pm25(value, percent);
    }
}