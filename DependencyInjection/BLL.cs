using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class BLL
    {

        // we can injedcting dependency with
        // 1. Injection using constructor
        // 2. Injection using property.
        // 3. Injection using method.
         

        IDAL _dAL;

        public BLL(IDAL dal)
        {
            _dAL = dal;
        }
        public void Insert()
        {
            /* DAL dAL = new DAL();
             dAL.Insert();*/
            // that is directly dependency on class object 
            // so for that we can achive with 

            _dAL.Insert();  

        }
    }
}
