using System.Collections.Generic;

namespace OOP.AbstractClassAndMethod
{
    public abstract class Heap
    {

        protected SortedSet<int> _list;

        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _list.Add(item);
        }

        //Abstract Method

        public abstract int Extract();


    }
}
