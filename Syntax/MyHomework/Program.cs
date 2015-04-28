
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Program
    {
       
        
            static void Main() {
            var emp = new Employee("Michael", "Jackson", "demult", "data.2015", 500000, 20);
            var lv = new Leave("20.10.2015", 5, "Pisica bolnava");
            emp.AddNewLeave(lv);
            emp.DisplayInfo();
            emp.ShowAllLeave();

            
      }
   }
}

