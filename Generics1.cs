using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This an example of generic method
namespace Arraylist
{
    public class Generics1
    {
        public bool Compare<T>(T a,T b)
        {
            //the equal operator= is not working with T and object type
            if(a.Equals(b))
                return true;
            return false;
        }
        static void Main()
        {
            Generics1 generics1 = new Generics1();
            //we give any type in the angle brecket this type take place of the T in Compare method
            bool result = generics1.Compare<int>(10, 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
