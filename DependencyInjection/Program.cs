using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* BLL b = new BLL(new DAL());
            b.Insert();*/


            UnityContainer container = new UnityContainer();
            container.RegisterType<IDAL, DAL>();

            BLL b = container.Resolve<BLL>();
            b.Insert();
                
            Console.ReadLine();


        }
    }
}
