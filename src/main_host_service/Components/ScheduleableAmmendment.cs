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
    public class ScheduleableAmmendment : Framework.FrameworkCore.ISchedulableAmmendment, INotifyPropertyChanged
    {
        ScheduleProperties _Property;
        string _Description;
        bool _Required;

        public ScheduleProperties Property
        {
            get => _Property;
            internal set
            {
                _Property = value;
                NotifyPropertyChanged();
            }
        }

        public string Description
        {
            get => _Description;
            set
            {
                if (_Description != value)
                {
                    _Description = value;
                    NotifyPropertyChanged();
                }
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


        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
