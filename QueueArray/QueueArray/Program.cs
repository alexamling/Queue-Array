using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueArray<int> queueArray = new QueueArray<int>(8);
            queueArray[0] = 7;
            queueArray[1] = 6;
            queueArray[2] = 5;
            queueArray[4] = 99;
            queueArray[5] = 1;
            queueArray[6] = 0;
            queueArray[7] = 10;

            Console.WriteLine(queueArray[0]);
            Console.WriteLine(queueArray[1]);
            Console.WriteLine(queueArray[2]);
            Console.WriteLine(queueArray[3]);
            Console.WriteLine(queueArray[4]);
            Console.WriteLine(queueArray[5]);
            Console.WriteLine(queueArray[6]);
            Console.WriteLine(queueArray[7]);
        }
    }
}
