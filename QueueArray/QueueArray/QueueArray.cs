using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArray
{
    class QueueArray<T>
    {
        private Queue<QueueItem<T>> queue;
        private int length;

        public int Length { get { return length; } }

        public T this[int index]
        {
            get
            {
                QueueItem<T> temp; // var to hold items while looping through the queue

                // get the desired index to the front of the queue
                for (int x = 0; x < index; x++)
                {
                    temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }

                T data = queue.Peek().Data; // retrieve desired data

                // rotate back through to the initia; index
                for (int x = 0; x < length - index; x++)
                {
                    temp = queue.Dequeue();
                    queue.Enqueue(temp);
                }

                return data;
            }
            set { }
        }

        public QueueArray(int len)
        {
            queue = new Queue<QueueItem<T>>();
            length = len;
            
            // need to populate the queue with null values, as if it was an array
            for (int x = 0; x < len; x++)
            {
                queue.Enqueue(new QueueItem<T>());
            }
        }
    }
}
