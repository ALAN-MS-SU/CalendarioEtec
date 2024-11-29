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

        public static readonly string CalendarsPath = $"{FileSystem.AppDataDirectory}/Calendars.txt";
     
    }
}
