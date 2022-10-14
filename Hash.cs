using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arraylist
{
    public class Hash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid",1001);
            ht.Add("Ename","Scott");
            ht.Add("Job","Manager");
            ht.Add("Salary",25000.00);
            ht.Add("Mgrid",1002);
            ht.Add("Phone",9487439303);
            ht.Add("Email","scott@gmail.com");
            ht.Add("Dname","Sales");
            ht.Add("Location","Mumbai");
            ht.Add("Did",30);
            //for print only single value
            Console.WriteLine(ht["Email"]);
            // for print all keys and values
            //in hashtable the values are not print in sequence
            foreach(object key in ht.Keys)
            {
                Console.WriteLine(key +":"+ ht[key]);
            }
            Console.ReadLine(); 
        }
    }
}
