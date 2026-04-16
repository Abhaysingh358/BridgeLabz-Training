using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.gcr_codebase.DSA.gcr_codebase.stack_queue_dictionary.SlidingWindowMaximum
{
    internal class Deque
    {
        private int[] data;
        private int front, rear, size, capacity;

        public Deque(int capacity)
        {
            this.capacity = capacity;
            data = new int[capacity];
            front = 0;
            size = 0;
            rear = -1;
        }

        public bool IsEmpty() => size == 0;

        public void AddRear(int value)
        {
            rear = (rear + 1) % capacity;
            data[rear] = value;
            size++;
        }

        public void RemoveRear()
        {
            rear = (rear - 1 + capacity) % capacity;
            size--;
        }

        public void AddFront(int value)
        {
            front = (front - 1 + capacity) % capacity;
            data[front] = value;
            size++;
        }

        public void RemoveFront()
        {
            front = (front + 1) % capacity;
            size--;
        }

        public int GetFront()
        {
            if (IsEmpty())
                throw new Exception("Deque is empty");
            return data[front];
        }

        public int GetRear()
        {
            if (IsEmpty())
                throw new Exception("Deque is empty");
            return data[rear];
        }
    }
}

