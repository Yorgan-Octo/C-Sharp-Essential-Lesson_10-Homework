using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public class MyList<T>
    {

        private T[] _items;
        
        public int Count
        {
            get { return _items.Length; }
        }

        public T this[int intdex]
        {
            get { return _items[intdex]; }
        }


        public void Add(T item)
        {
            if (_items == null)
            {
                _items = new T[0];
            }
         

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
