using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtecCalendario.data
{
    internal class Turma(string name,string materia)
    {
        string Name { get; set; } = name;

        string Materia { get; set; } = materia;


    }
}
