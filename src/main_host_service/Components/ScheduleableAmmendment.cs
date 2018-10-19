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
		string _Name;
		IObjectType _ObjectType;
		ICollection<object> _Value;
		ScheduleProperties _Property;
		string _Description;
		bool _Required;

		public ScheduleProperties Property
		{
			get => _Property;
			set
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

		public string Name
		{
			get => _Name;
			set
			{
				if(_Name != value)
				{
					_Name = value;
					NotifyPropertyChanged();
				}
			}
		}

		public IObjectType ObjectType
		{
			get => _ObjectType;
			set
			{
				_ObjectType = value;
				NotifyPropertyChanged();
			}
		}

		public ICollection<object> Value
		{
			get => _Value;
			private set
			{
				_Value = value;
				NotifyPropertyChanged();
			}
		}

		#region Events

		public event PropertyChangedEventHandler PropertyChanged;

		void NotifyPropertyChanged([CallerMemberName]string value = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));

		#endregion
	}
}
