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
    public class Contact : Framework.FrameworkCore.IContact, INotifyPropertyChanged
    {
        string _DisplayName;
        string _FirstName;
        string _LastName;
        string _EMail;
        string _Phone;
        IPhysicalAddress _Address;

        public string DisplayName
        {
            get => _DisplayName; set
            {
                if (_DisplayName != value)
                {
                    _DisplayName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string FirstName
        {
            get => _FirstName;
            set
            {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string LastName
        {
            get => _LastName;
            set
            {
                if (_LastName != value)
                {
                    _LastName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string EMail
        {
            get => _EMail;
            set
            {
                if (_EMail != value)
                {
                    _EMail = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Phone
        {
            get => _Phone; set
            {
                if (_Phone != value)
                {
                    _Phone = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public IPhysicalAddress PhysicalAddress
        {
            get => _Address;
            set
            {
                _Address = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName] string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
    }
}
