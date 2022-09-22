using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(10);
            list.Add(40);
            list.Add(30);
            list.Add(10);
            list.Add(50);
            list.Insert(2, 12);
            //list.IndexOf(20);
            //list.LastIndexOf(20);
            //list.Clear();
            //list.Remove(30);
            //list.RemoveAt(0);
            Stack stack = new Stack();
            stack.Push(50);  
            stack.Pop();
           // stack.Peek();
           Queue queue = new Queue();
            queue.Enqueue(30);
            queue.Dequeue();
           // queue.Peek();
            Console.WriteLine($"Capacity of list is {list.Capacity}");
            Console.WriteLine(list.Count);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
