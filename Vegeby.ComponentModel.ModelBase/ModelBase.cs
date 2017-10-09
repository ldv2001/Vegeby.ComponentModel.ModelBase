using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Vegeby.ComponentModel
{
    public abstract class ModelBase : INotifyPropertyChanged, INotifyPropertyChanging
    {
        protected virtual bool AdvertiseChanged => true;
        protected virtual bool AdvertiseChanging => true;

        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangingEventHandler PropertyChanging;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public void OnPropertyChanging([CallerMemberName] string propertyName = null) => PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));

        public void SetProperty<T>(ref T destination, T value)
        {
            if (AdvertiseChanging) OnPropertyChanging();
            destination = value;
            if (AdvertiseChanged) OnPropertyChanged();
        }
    }
}
