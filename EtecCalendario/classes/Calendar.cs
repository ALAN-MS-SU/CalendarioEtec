using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.classes;

public class Calendar(string id, string class_, string subject)
{
    public readonly string ID = id ;
    public string Class { get; set; } = class_;
    public string Subject { get; set; } = subject;

    private readonly List<DateCalendar> Dates = [];

    public static readonly string CalendarsPath = $"{FileSystem.AppDataDirectory}/Calendars.txt";
    
    public static void Delete_Calendar(Calendar Calendar_Delet)
    {
        List<string> file = File.ReadAllLines(CalendarsPath).ToList();
        StreamWriter writer = new(CalendarsPath,false);
        foreach (string calendar in file)
        {
            string[] Split = calendar.Split("|");
            if (Calendar_Delet.ID != Split[0])
            {
                writer.WriteLine(calendar);
            }
            if(Calendar_Delet.ID == Split[0])
            {
                DateCalendar.Delet_Date(null,Calendar_Delet.ID);
            }
        }
        writer.Close();

    }
}
