using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here we can create nth number of object of customer class
            // for ex:
            /* customer c=new customer();
             customer c1= new customer();
             customer c2= new customer();
             customer c3= new customer(); // ....*/

            // so here heap memory me sab ke liye alag alag object banega.
            // to memory jyada loose ho jayegi.

            singleton c1 = singleton.instance;
            singleton c2 = singleton.instance;
            singleton c3 = singleton.instance;
            singleton c4 = singleton.instance;

            // so here we make one singleton object which points to all object.
            // to check these are points to one object
            // for that we can use compare or equals method.
            if (c2.Equals(c1))
            {
                Console.WriteLine("c1 and c2 are equals");
            }
            else
            {
                Console.WriteLine("c1 and c2 are equals");

            }

            Console.ReadLine();

        }
    }

    public  sealed class singleton
    {
        // crreate static field
        static singleton _obj = null;

        // here we can control multithreading access for that we use lock()
        static object o = new object();
        // create private constructor bcs we can not aalow to class to create object
        private singleton() { }
        // write a method for logic
        public static singleton instance
        {
            get
            {
                if (_obj == null)
                {
                    lock (o)
                    {
                        if (_obj == null)
                        {
                            _obj = new singleton();
                        }
                        return _obj;
                    }
                }
                return _obj;
            }

        }
    }
}
