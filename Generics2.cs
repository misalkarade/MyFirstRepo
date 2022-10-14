using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This an example of generic class
// In this for exicuting the generic class we have to declare object of generic class in another class 
namespace Arraylist
{
    public class Generics2<T>
    {
        public void Add(T a,T b)
        {
            //A dynamic is keyword which is used for declare a variable. dynamic identify the veriable at a run time
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1+d2);
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
        
    }
    class Test
    {
        static void Main()
        {
            Generics2<int> s = new Generics2<int>();
            s.Add(10, 20);
            s.Sub(20, 10);
            s.Mul(20, 20);
            s.Div(20, 5);
            Console.ReadLine();
        }
    }
}
