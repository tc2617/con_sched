using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class OpenCloseTime : Framework.FrameworkCore.IOpenClose, INotifyPropertyChanged
    {
        DateTime _OpenTime;
        DateTime _CloseTime;
        bool _NonAttendeeUsage;

        public DateTime OpenTime
        {
            get => _OpenTime;
            set
            {
                _OpenTime = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime CloseTime
        {
            get => _CloseTime;
            set
            {
                _CloseTime = value;
                NotifyPropertyChanged();
            }
        }

        public bool NonAttendeeUsage
        {
            get => _NonAttendeeUsage;
            set
            {
                _NonAttendeeUsage = value;
                NotifyPropertyChanged();
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
