using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProgramacionIntermedia
{
    public static class RegexValidation
    {
        public static void regexValidation(this string value)
        {
            Regex validacion = new Regex(@"(^[A-Z])([a-z]{3})\d{4}$");

            if (validacion.IsMatch(value))
            {
                Console.WriteLine("Cadena valida");
            }
            else
            {
                Console.WriteLine("Cadena NO valida");
            }
        }
    }
}
