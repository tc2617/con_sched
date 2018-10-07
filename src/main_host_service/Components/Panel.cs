using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Framework.FrameworkCore;

namespace Components
{
    [DataContract]
    public class Panel : Framework.FrameworkCore.ISchedulableItem, INotifyPropertyChanged
    {
        #region Properties

        string _Name;
        ICollection<IScheduleContact> _Contacts = new HashSet<IScheduleContact>();
        decimal _Length;
        ICollection<ISchedulableAmmendment> _Ammendments = new HashSet<ISchedulableAmmendment>();

        [DataMember]
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

        [DataMember]
        public ICollection<IScheduleContact> Contacts { get => _Contacts; }

        [DataMember]
        public decimal Length {
            get => _Length;
            set
            {
                _Length = value;
                NotifyPropertyChanged();
            }
        }

        [DataMember]
        public ICollection<ISchedulableAmmendment> Ammendments { get => _Ammendments; }

        #endregion

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

        #endregion
    }
}
