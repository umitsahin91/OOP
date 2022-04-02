using System.Collections.Generic;

namespace OOP.AbstractClassAndMethod
{
    public class MaxHeap : Heap
    {
        
        public override int Extract()
        {
            var item = _list.Max;
            _list.Remove(item);
            return item;

        }
    }
}
