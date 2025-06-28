using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DataStructrue
{
    public class AmmarList<T> : List<T>
    {
        T[] items;
        public int Capacity = 4;
        public int CurrentIndex;
        private int _count;



        public AmmarList()
        {
            items = new T[Capacity];
            CurrentIndex = 0;
            _count = 0;
        }
        public AmmarList(int capacity)
        {
            Capacity = capacity;
            items = new T[Capacity];
            CurrentIndex = 0;
            _count = 0;
        }
        public T this[int index]
        {
            get
            {
                if(index< 0 || index >= items.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                return items[index];
            }
            set
            {
                if (index < 0 || index >= items.Length)
                    throw new IndexOutOfRangeException("Index out of range");
                items[index] = value;
            }

        }
        //public T<string> this[string index]
        //{
           
        //}

    }
}
