using System;
using System.Collections.Generic;
using System.Text;

namespace kampödevDictionary
{
    class MyDictonary<Mkey,Kvalue>
    {
        private Mkey[] keys;
        private Kvalue[] values;
        public MyDictonary()
        {
            keys = new Mkey[0];
            values = new Kvalue[0];
        }
        public void Add(Mkey key ,Kvalue value)
        {
            Mkey[] tempkey = keys;
            Kvalue[] tempvalue = values;

            for (int i = 0; i < tempkey.Length; i++)
            {
                keys[i] = tempkey[i];
            }

            for (int i = 0; i < tempvalue.Length; i++)
            {
                values[i] = tempvalue[i];
            }
            

            Console.WriteLine("Key : " + key + " and Value : " + value );
        }
    }
}
