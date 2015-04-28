using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    public class NegativeLeaveDays : Exception
    {
        public NegativeLeaveDays()
        {
            Console.WriteLine("Numarul de zile ramase nu poate fi mai mare decat durata concediului");
        }
    }
}
