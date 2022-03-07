using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionIntermedia
{
    public class Map<T> where T : AbstractCuartaParte
    {
        private T[] arreglo = new T[10];

        public dynamic this[int index] 
        {
            get => GetFieldByPosition(index);
            set => arreglo[index] = value; 
        }
            
        private dynamic GetFieldByPosition(int position)
        {
            if(arreglo[position] == null)
            {
                Console.WriteLine("elemento inexistente");
            }

            return arreglo[position];
        }

        public dynamic this[string textValue] => GetFieldByString(textValue);
        private dynamic GetFieldByString(string searchField)
        {
            try
            {
                foreach (var item in arreglo)
                {
                    if (item.key.Equals(searchField))
                    {
                        return item;
                    }
                }
                throw new ExcepcionPersonal("elemento no existe");
            }
            catch (ExcepcionPersonal ex)
            {
                Console.WriteLine(ex);
            }
            return "elemento no existe";    
        }
    }
}
