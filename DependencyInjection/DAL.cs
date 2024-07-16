using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
  public  class DAL :IDAL
    {
        public void Insert()
        {
            // ado.net code
            Console.WriteLine("Data Inserted successfully");    
        }

    }
}
