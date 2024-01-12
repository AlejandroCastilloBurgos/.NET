using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class Utils
    {
        public static void AddRangeDictionary<K,V>(Dictionary<K,V> dictionary, List<KeyValuePair<K, V>> elements)
        {
            foreach(var KeyValue in elements)
            {
                dictionary.Add(KeyValue.Key, KeyValue.Value);
            }
        }
        public static void AddRange<K, V>(this Dictionary<K, V> dictionary, List<KeyValuePair<K,V>>elements)
        {
            foreach(var KeyValue in dictionary) 
            {
                dictionary.Add(KeyValue.Key, KeyValue.Value);
            }
        }

    }
}
