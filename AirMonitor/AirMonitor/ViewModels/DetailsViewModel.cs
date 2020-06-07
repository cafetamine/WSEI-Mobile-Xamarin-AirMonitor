using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AirMonitor.ViewModels
{
    public class DetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        private const int DefaultCaqi = 101;
        
        private int _caqi = DefaultCaqi;
        public int Caqi
        {
            get => _caqi;
            set => SetProperty(ref _caqi, value);
        }

        public DetailsViewModel()
        {
            //..
        }

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        private bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }
            field = value;
            RaisePropertyChanged(propertyName);

            return true;
        }
    }
}
