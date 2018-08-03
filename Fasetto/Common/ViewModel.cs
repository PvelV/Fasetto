using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Common
{
    [ImplementPropertyChanged]
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        //public void SetProperty<object>(ref T backingField, T value, [CallerMemberName] string propertyName = null)
        //{
        //    if (!EqualityComparer<object>.Default.Equals(backingField, value))
        //    {
        //        OnPropertyChanged(propertyName);
        //    }
        //}
    }
}
