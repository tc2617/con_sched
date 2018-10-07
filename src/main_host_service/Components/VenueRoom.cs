using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class VenueRoom : Framework.FrameworkCore.IVenueRoom, INotifyPropertyChanged
    {
        string _Name;
        string _RoomNumber;
        ICollection<string> _Features;

        public string Name
        {
            get => _Name;
            set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string RoomNumber
        {
            get => _RoomNumber;
            set
            {
                if (_RoomNumber != value)
                {
                    _RoomNumber = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICollection<string> Features
        {
            get => _Features;
            internal set
            {
                _Features = value;
                NotifyPropertyChanged();
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
