using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //the capacity of list is increase in double of the value(or initial value)
            //in array list the list is auto increment
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
            Console.WriteLine(al.Capacity);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            //to insert values between values
            al.Insert(3, 350);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            //to remove values from the list. two way to remove values
            //al.Remove(200);
            al.RemoveAt(1);
            foreach (object obj in al)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();
            
        }
    }
}

