using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, L>
    {
        T[] keys;
        L[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new L[0];
        }

        public void Add(T key, L value)
        {
            T[] tempKey = keys;
            keys = new T[tempKey.Length + 1];
            L[] tempValue = values;
            values = new L[tempValue.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("İsim : " + keys[i]+", Numara : "+values[i]);
            }
        }
    }
}
