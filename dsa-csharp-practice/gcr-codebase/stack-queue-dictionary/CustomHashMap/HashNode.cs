using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.CustomHashMap
{
    public class HashNode<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;
        public HashNode<TKey, TValue> Next;

        public HashNode(TKey key, TValue value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
