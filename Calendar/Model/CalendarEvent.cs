using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Model
{
	class CalendarEvent
	{
		CalendarDay startingDay;
		CalendarDay finishDay;

		internal CalendarDay StartingDay { get => startingDay; set => startingDay = value; }
		internal CalendarDay FinishDay { get => finishDay; set => finishDay = value; }
	}
}
