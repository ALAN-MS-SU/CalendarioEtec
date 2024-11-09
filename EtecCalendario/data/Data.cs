using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EtecCalendario.classes;
namespace EtecCalendario.data
{
    internal static class Data
    {
        public static readonly string DatesPath = $"{FileSystem.AppDataDirectory}/Dates.txt";

        public static readonly string CalendarsPath = $"{FileSystem.AppDataDirectory}/Calendars.txt";
    }
}

