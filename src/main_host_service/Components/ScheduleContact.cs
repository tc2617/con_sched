using System.ComponentModel;
using System.Runtime.CompilerServices;
using Framework.FrameworkCore;

namespace Components
{
	class ScheduleContact : IScheduleContact, INotifyPropertyChanged
	{
		IContact _Contact;
		bool _Primary;
		bool _Required;

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

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

		#endregion
	}
}
