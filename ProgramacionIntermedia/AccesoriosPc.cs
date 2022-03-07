using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia
{
    public class AccesoriosPc : AbstractCuartaParte
    {
        public AccesoriosPc(string AccesoriosKey, dynamic AccesoriosValue)
        {
            this.key = AccesoriosKey;
            this.value = AccesoriosValue;
        }

        public void MosttrarAccesorio()
        {
            Console.WriteLine("Accesorio: " + key);
            Console.WriteLine("Cantidad: " + value);
        }


    }
}
