using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Framework.FrameworkCore;

namespace Components
{
	[DataContract]
	public class Panel : Framework.FrameworkCore.ISchedulableItem, INotifyPropertyChanged
	{
		#region Properties

		string _Name;
		string _Description;
		decimal _Length;
		ICollection<ISchedulableResource> _Resources = new HashSet<ISchedulableResource>();

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

		[DataMember]
		public decimal Duration
		{
			get => _Length;
			set
			{
				_Length = value;
				NotifyPropertyChanged();
			}
		}

		[DataMember]
		public ICollection<ISchedulableResource> Resources
		{
			get => _Resources;
			set
			{
				_Resources = value;
				NotifyPropertyChanged();
			}
		}

		#endregion

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

		#endregion
	}
}
