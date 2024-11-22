using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.classes
{
    public class Calendar(string id, string class_,string subject )
    {
        public readonly string ID = id;
        public string Class { get; set; } = class_;
        public string Subject { get; set; } = subject;

        private readonly List<DateCalendar> Dates = [];

        public bool NewDate(DateCalendar data)
        {
            try
            {
                
                return true;
            }
            catch (Exception err)
            {

                return false;
            }
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
    }
}
