using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.CustomHashMap
{
        public class MyHashMap<TKey, TValue>
        {
            private HashNode<TKey, TValue>[] buckets;
            private int capacity;

            public MyHashMap(int capacity = 10)
            {
                this.capacity = capacity;
                buckets = new HashNode<TKey, TValue>[capacity];
            }

            private int GetBucketIndex(TKey key)
            {
                int hash = key.GetHashCode();
                return Math.Abs(hash) % capacity;
            }

            public void Put(TKey key, TValue value)
            {
                int index = GetBucketIndex(key);
                HashNode<TKey, TValue> head = buckets[index];

                while (head != null)
                {
                    if (head.Key.Equals(key))
                    {
                        head.Value = value;
                        return;
                    }
                    head = head.Next;
                }

                HashNode<TKey, TValue> newNode =
                    new HashNode<TKey, TValue>(key, value);

                newNode.Next = buckets[index];
                buckets[index] = newNode;
            }

            public TValue Get(TKey key)
            {
                int index = GetBucketIndex(key);
                HashNode<TKey, TValue> head = buckets[index];

                while (head != null)
                {
                    if (head.Key.Equals(key))
                        return head.Value;
                    head = head.Next;
                }

                throw new Exception("Key not found");
            }

            public void Remove(TKey key)
            {
                int index = GetBucketIndex(key);
                HashNode<TKey, TValue> head = buckets[index];
                HashNode<TKey, TValue> prev = null;

                while (head != null)
                {
                    if (head.Key.Equals(key))
                    {
                        if (prev == null)
                            buckets[index] = head.Next;
                        else
                            prev.Next = head.Next;
                        return;
                    }
                    prev = head;
                    head = head.Next;
                }

                throw new Exception("Key not found");
            }
        }
}


