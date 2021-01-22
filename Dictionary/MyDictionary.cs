using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<T1,T2>
    {
        T1[] itemss;
        T2[] itemm;

        public MyDictionary()
        {
            itemss = new T1[0];
            itemm = new T2[0];

        }
        public void Add(T1 items , T2 item)
        {
            T1[] tempArray = itemss ;
            T2[] tempArray1 = itemm;

            itemss = new T1[itemss.Length + 1];
            itemm = new T2[itemm.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                itemss[i] = tempArray[i];
                itemm[i] = tempArray1[i];
            }
           
            itemss[itemss.Length - 1] = items;
            itemm[itemm.Length - 1] = item;
        }
    }
}
