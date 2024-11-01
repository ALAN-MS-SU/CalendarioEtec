using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.classes
{
    public class Calendar()
    {
       public string Class { get; set; }
       public string Subject { get; set; }
       private List<DateCalendar> Dates = [];

       public void NewDate(DateCalendar data)
        {
            this.Dates.Add(data);
        }
       public void DeleteDate(DateCalendar data)
        {
           for(int i = 0; i <= this.Dates.Count - 1;i++)
            {
                if(data == this.Dates[i])
                {
                    this.Dates.Remove(this.Dates[i]);
                    return;
                }
            }
        }
        public void InspireDate()
        {
            for (int i = 0; i <= this.Dates.Count;i++)
            {
                if (this.Dates[i].Day < DateTime.Now)
                {
                    this.Dates.Remove(this.Dates[i]);
                }
            }
        }
        public DateCalendar[] AllDates()
        {
            return [..this.Dates];
        }
    }
}
