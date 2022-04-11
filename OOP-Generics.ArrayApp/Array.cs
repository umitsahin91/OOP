using System.Collections;
using System.Linq;

namespace OOP_Generics.ArrayApp
{
    public class Array<T>:IEnumerable
    {
        private T[] InnerList;
        private int index;
        public Array(int size=16)
        {
            InnerList = new T[size];
            index = 0;
        }
        public Array(params T[] collection)
        {
            InnerList = new T[collection.Length];
            index = 0;
            foreach (var item in collection)
            {
                InnerList[index] = item;
                index++;
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return InnerList.Take(index).GetEnumerator();
        }
    }
}
