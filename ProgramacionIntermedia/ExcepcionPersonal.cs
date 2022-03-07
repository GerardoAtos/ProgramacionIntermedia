using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia
{
    public class ExcepcionPersonal : NullReferenceException
    {
        public ExcepcionPersonal(string mensaje) : base(mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
