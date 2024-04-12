using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olpak.genericarraylist
{
    public class Array<T>:IEnumerable
        where T : class
    {
        private T[] InnerList;
        private int Index;

        public Array(int size=16)
        {
            InnerList = new T[size];
            Index = 0;
        }

        public Array(params T[] colletion)
        {
            InnerList = new T[colletion.Length];
            Index = 0;
            foreach (var i in colletion)
            { 
                InnerList[Index] = i;
                Index++;
            }

        }

        public IEnumerator GetEnumerator()
        {
            return InnerList.Take(Index).GetEnumerator();
        }
    }
}
