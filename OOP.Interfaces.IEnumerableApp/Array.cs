using System.Collections;
using System.Linq;

namespace OOP.Interfaces.IEnumerableApp
{
    public class Array : IEnumerable
    {
        private int[] InnerList { get; set; }
        private int index=0;
        public Array(int size=16)
        {
            InnerList = new int[size];
        }
        public Array(params int[] initial)
        {
            InnerList = new int[initial.Length];
            foreach (var item in initial)
            {
                InnerList[index] = item;
                index++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            //return InnerList.Take(index).GetEnumerator();
            return new ArrayEnumerator(InnerList);
        }

        private class ArrayEnumerator : IEnumerator
        {
            private int[] InnerList;
            private int index;
            public object Current => InnerList[index];
            public ArrayEnumerator(int[] arr)
            {
                InnerList = arr;
                //index = -1;
                index = InnerList.Length;
            }
            public bool MoveNext()
            {
                if (index==InnerList.Length)
                {
                    index--;
                    return true;
                }
                if (index > 0)
                {
                    index--;
                    return true;
                }
                else
                    index = InnerList.Length;
                    return false;
            }

            public void Reset()
            {
                index = InnerList.Length;
            }
        }
    }
}
