using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public class MyList<T>
    {

        private T[] _items = new T[0];
        
        public int Count
        {
            get { return _items.Length; }
        }

        public T this[int intdex]
        {
            get { 
                
                if (intdex >= 0 && intdex < _items.Length)
                {
                    return _items[intdex]; 

                }

                throw new ArgumentException("Вихід за межі");

            }
        }


        public void Add(T item)
        {

            //можно булоб зробити і церез  Array.Resize це для практики
            T[] tempItems = new T[_items.Length +1];

            
            for (int i = 0; i < _items.Length; i++)
            {
                tempItems[i] = _items[i];
            }

            tempItems[_items.Length] = item;

            _items = tempItems;
        }

    }
}
