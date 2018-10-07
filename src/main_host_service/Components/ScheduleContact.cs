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
    class ScheduleContact : Framework.FrameworkCore.IScheduleContact, INotifyPropertyChanged
    {
        IContact _Contact;
        bool _Primary;
        bool _Required;
        bool _EventVIP;

        public IContact Contact
        {
            get => _Contact;
            set
            {
                _Contact = value;
                NotifyPropertyChanged();
            }
        }

        public bool Primary
        {
            get => _Primary;
            set
            {
                _Primary = value;
                NotifyPropertyChanged();
            }
        }

        public bool Required
        {
            get => _Required;
            set
            {
                _Required = value;
                NotifyPropertyChanged();
            }
        }

        public bool EventVIP
        {
            get => _EventVIP; set
            {
                _EventVIP = value;
                NotifyPropertyChanged();
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
