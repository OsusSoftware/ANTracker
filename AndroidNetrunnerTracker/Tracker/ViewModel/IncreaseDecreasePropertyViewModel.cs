using System.ComponentModel;
using System.Windows.Input;
using Tracker.Commands;

namespace Tracker.ViewModel
{
    public class IncreaseDecreasePropertyViewModel : INotifyPropertyChanged
    {
        private int _count;

        public IncreaseDecreasePropertyViewModel()
        {
            this.IncreaseCommand = new ButtonCommand(
                (o) => Count++,
                null);
            this.DecreaseCommand = new ButtonCommand(
                (o) => Count--,
                (o) => Count > 0);
        }

        public IncreaseDecreasePropertyViewModel(string propertyName) : this()
        {
            this.PropertyName = propertyName;
        }

        public string PropertyName { get; set; }
        public ICommand IncreaseCommand { get; set; }
        public ICommand DecreaseCommand { get; set; }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if(value != this._count)
                {
                    this._count = value;
                    NotifyPropertyChanged("Count");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
