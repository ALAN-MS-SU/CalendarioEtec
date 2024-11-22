using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.classes
{
    public class DateCalendar(DateTime day,string title)
    {
       public DateTime Day { get; set; } = day.Date;
       public string Title { get; set; } = title;



    }
}
