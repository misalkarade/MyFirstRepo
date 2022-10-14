using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//In nongeneric collection we use hashtable for store key and values
//but in generic collection we use dictionary for store tpye safe key and values
//the dictionary print values in the sequence
namespace Arraylist
{
    public class Dictionary1
    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Eid", 1001);
            dt.Add("Ename", "Scott");
            dt.Add("Job", "Manager");
            dt.Add("Salary", 25000.00);
            dt.Add("Mgrid", 1002);
            dt.Add("Phone", 9487439303);
            dt.Add("Email", "scott@gmail.com");
            dt.Add("Dname", "Sales");
            dt.Add("Location", "Mumbai");
            dt.Add("Did", 30);
            foreach (string key in dt.Keys)
                Console.WriteLine(key + " " + dt[key]);
            Console.ReadLine();
        }
    }
}
