using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EtecCalendario.classes;

public class DateCalendar(DateTime day, string title)
{
    public DateTime Day { get; set; } = day.Date;
    public string Title { get; set; } = title;

    public static readonly string DatesPath = $"{FileSystem.AppDataDirectory}/Dates.txt";


    public static void Delet_Date(DateCalendar? date_delet = null, string? id = null)
    {

        List<string> file = File.ReadAllLines(DatesPath).ToList();
        StreamWriter writer = new(DatesPath, false);
        if (id == null && date_delet != null)
        {
            foreach (string date in file)
            {
                string[] split = date.Split("|");

                if (split[1] != date_delet.ToString() && split[2] != date_delet.Title)
                {
                    writer.WriteLine(date);
                }

            }
        }
        if (id != null && date_delet == null)
        {
            foreach (string date in file)
            {
                string[] split = date.Split("|");

                if (split[0] != id)
                {
                    writer.WriteLine(date);
                }

            }
        }

        writer.Close();

    }
}
