using System.ComponentModel;

namespace FSync.ViewModels
{
    public class SummaryViewModel : INotifyPropertyChanged
    {
        private int _CaloriesLeft;
        public int CaloriesLeft
        {
            get { return _CaloriesLeft; }
            private set 
            { 
                _CaloriesLeft = value;
                NotifyPropertyChanged("CaloriesLeft");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
