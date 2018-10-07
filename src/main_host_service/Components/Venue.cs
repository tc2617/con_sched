using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Framework.FrameworkCore;

namespace Components
{
    public class Venue : Framework.FrameworkCore.IVenue, INotifyPropertyChanged
    {
        string _Name;
        IPhysicalAddress _Address;
        ICollection<IContact> _Contacts;
        ICollection<IVenueRoom> _Rooms;

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

        public IPhysicalAddress Address
        {
            get => _Address;
            set
            {
                _Address = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<IPhysicalAddress> ServiceAddresses { get; set; }

        public ICollection<IContact> Contacts => _Contacts;

        public ICollection<IVenueRoom> VenueRooms => _Rooms;

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
    }
}
