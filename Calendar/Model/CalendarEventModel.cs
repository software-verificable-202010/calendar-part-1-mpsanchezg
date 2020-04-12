using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Model
{
	public class CalendarEventModel { }

	public class CalendarEvent : INotifyPropertyChanged
	{
		private DateTime startDate;
		private DateTime finishDate;
		private string name;

		public DateTime StartDate
		{
			get
			{
				return startDate;
			}
			set
			{
				if(startDate != value)
				{
					startDate = value;
					RaiseDateTimePropertyChanged(Constants.StartDateEventProperty);
				}
			}
		}

		public DateTime FinishDate
		{
			get
			{
				return finishDate;
			}
			set
			{
				if (finishDate != value)
				{
					finishDate = value;
					RaiseDateTimePropertyChanged(Constants.FinishDateEventProperty);
				}
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (name != value)
				{
					name = value;
					RaiseDateTimePropertyChanged(Constants.NameEventProperty);
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void RaiseDateTimePropertyChanged(string property)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
		}
	}

}
