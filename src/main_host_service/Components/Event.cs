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
    public class Event : Framework.FrameworkCore.IEvent, INotifyPropertyChanged
    {
        string _Name;
        ICollection<IEventRoom> _Rooms;
        ICollection<IVenue> _Venues;
        ICollection<IScheduleContact> _Contacts;
        IOpenClose _OpenClose;

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

        public IOpenClose OpenClose
        {
            get => _OpenClose;
            set
            {
                _OpenClose = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<IEventRoom> EventRooms
        {
            get => _Rooms;
            internal set
            {
                _Rooms = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<IVenue> Venues
        {
            get => _Venues;
            internal set
            {
                _Venues = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<IScheduleContact> Contacts
        {
            get => _Contacts;
            internal set
            {
                _Contacts = value;
                NotifyPropertyChanged();
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
