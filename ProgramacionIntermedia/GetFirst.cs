using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia
{
    public static class GetFirst
    {
        public static void GetFirstElement(this Map<AccesoriosPc> arreglo) 
        {
            string Key = arreglo[0].key.ToString();
            dynamic Value = arreglo[0].value;

            Console.WriteLine($"El primer valor del arreglo es {Key} , cantidad: {Value}");
        }
    }
}
