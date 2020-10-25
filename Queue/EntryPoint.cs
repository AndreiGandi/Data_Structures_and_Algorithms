using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Queue orderNo = new Queue(5);
            orderNo.Insert("Andrei");
            orderNo.Insert("John");
            orderNo.Insert("Marry");
            orderNo.Insert("Jack");
            orderNo.Insert("Ivan");

            orderNo.DisplayQueue();
        }
    }
}
