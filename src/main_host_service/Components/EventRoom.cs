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
    public class EventRoom : Framework.FrameworkCore.IEventRoom, INotifyPropertyChanged
    {
        string _Name;
        IVenueRoom _Room;
        ICollection<IOpenClose> _OpenCloseSchedule;
        ICollection<ISchedulableItem> _ScheduleItems;
        ICollection<string> _Ammendments;
        IList<ISchedulableItem> _ScheduleOrder;
        TimeSpan _ScheduleBreaks;

        public string Name
        {
            get => _Name; set
            {
                if (_Name != value)
                {
                    _Name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IVenueRoom Room
        {
            get => _Room;
            set
            {
                _Room = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<IOpenClose> OpenCloseSchedule
        {
            get => _OpenCloseSchedule;
            set
            {
                _OpenCloseSchedule = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<ISchedulableItem> ScheduleItems
        {
            get => _ScheduleItems;
            set
            {
                _ScheduleItems = value;
                NotifyPropertyChanged();
            }
        }

        public ICollection<string> SchedulerAmmendments
        {
            get => _Ammendments;
            set
            {
                _Ammendments = value;
                NotifyPropertyChanged();
            }
        }

        public IList<ISchedulableItem> ScheduleOrder
        {
            get => _ScheduleOrder;
            set
            {
                _ScheduleOrder = value;
                NotifyPropertyChanged();
            }
        }

        public TimeSpan ScheduleBreaks
        {
            get => _ScheduleBreaks; set
            {
                _ScheduleBreaks = value;
                NotifyPropertyChanged();
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
