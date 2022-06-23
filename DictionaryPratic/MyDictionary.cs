using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPratic
{
    public class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;

        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }

        public void Add(K key, V value)
        {
            K[] _tempKey = _key;
            V[] _tempValues = _value;
            _key = new K[_key.Length + 1];
            _value = new V[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValues[i];
            }

            _key[_key.Length - 1] = key;
            _value[_key.Length - 1] = value;
        }

        public void Listele()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("[{0}, {1}]", _key[i], _value[i]);
            }
        }

        public int Count
        {
            get { return _key.Length; }
        }
    }
}
