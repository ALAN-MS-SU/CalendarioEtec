using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.classes
{
    internal class Calendar(string class_, string subject)
    {
       public string Class = class_;
       public string Subject = subject;
       private List<classes.Date> Dates = [];

       public void NewDate(classes.Date data)
        {
            this.Dates.Append(data);
        }
       public void DeleteDate(classes.Date data)
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
