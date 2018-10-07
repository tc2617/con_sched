using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class PhysicalAddress : Framework.FrameworkCore.IPhysicalAddress, INotifyPropertyChanged
    {
        string _Street1;
        string _Street2;
        string _City;
        string _State;
        string _ZipCode;


        public string Street1
        {
            get => _Street1;
            set
            {
                if (_Street1 != value)
                {
                    _Street1 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Street2
        {
            get => _Street2;
            set
            {
                if (_Street2 != value)
                {
                    _Street2 = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string City
        {
            get => _City;
            set
            {
                if (_City != value)
                {
                    _City = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string State
        {
            get => _State;
            set
            {
                if (_State != value)
                {
                    _State = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string ZipCode
        {
            get => _ZipCode;
            set
            {
                if (_ZipCode != value)
                {
                    _ZipCode = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
