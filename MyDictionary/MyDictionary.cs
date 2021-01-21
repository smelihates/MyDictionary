using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey, TValue>
    {
        Tkey[] _keys;
        TValue[] _values;

        public MyDictionary()
        {
            _keys = new Tkey[0];
            _values = new TValue[0];
        }

        public void Add(Tkey key,TValue value)
        {
            Tkey[] tempKeys = _keys;
            TValue[] tempValues = _values;

            _keys = new Tkey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];
            for (int i = 0; i < tempKeys.Length; i++)
            {
                _keys[i] = tempKeys[i];
                _values[i] = tempValues[i];
            }
            _keys[_keys.Length - 1] = key;
            _values[_values.Length - 1] = value;
            
        }

        public int Count 
        {
            get { return _keys.Length; } 
        }
       


    }
}
