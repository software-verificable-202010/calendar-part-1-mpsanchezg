using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum WeekDays
{
	Monday = 1,  // 1
	Tuesday = 2,  // 2
	Wednesday = 3,  // 4
	Thursday = 4,  // 8
	Friday = 5,  // 16
	Saturday = 6,  // 32
	Sunday = 7,  // 64
}


namespace Calendar.Model
{
	class CalendarDay
	{
		int numberOfDay;
		WeekDays dayOfWeek;

		public CalendarDay()
		{

		}

		public int NumberOfDay { get => numberOfDay; set => numberOfDay = value; }
		public WeekDays DayOfWeek { get => dayOfWeek; set => dayOfWeek = value; }
		
	}
}
