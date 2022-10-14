using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    public class list
    {
        static void Main(string[] args)
        {
            //we make list using defferent data type
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            li.Add(4);
            li.Add(5);
            li.Add(6);
            for (int i = 0; i < li.Count; i++)
                Console.Write(li[i] +" ");
            Console.WriteLine();
            //for adding values
            li.Insert(3, 35);
            foreach (int i in li)
                Console.Write(i+" ");
            Console.WriteLine();
            //for removing values from list
            li.RemoveAt(0);
            foreach (int i in li)
                Console.Write(i + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
