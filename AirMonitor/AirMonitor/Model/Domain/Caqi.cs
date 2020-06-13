namespace AirMonitor.Model.Domain
{
    public class Caqi
    {
        private const int DefaultValue = 101;
        private const string DefaultTitle = "Świetna jakość!";
        private const string DefaultDescription = "Możesz bezpiecznie wyjść z domu bez swojej maski anty-smogowej i nie bać się o swoje zdrowie.";
            
        private int _value;
        private string _title;
        private string _description;
        
        public int Value
        {
            get => _value;
            set => _value = value;
        }
        
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        private Caqi(int value, string title, string description)
        {
            _value = value;
            _title = title;
            _description = description;
        }

        public static Caqi Default() => new Caqi(DefaultValue, DefaultTitle, DefaultDescription);
        
        public static Caqi Create(int value, string title, string description)
            => new Caqi(value, title, description);
    }
}