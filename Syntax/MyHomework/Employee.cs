using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomework
{
    class Employee : Person
    {
        protected string dateOfEmployement;
        protected int salary;
        protected int availableDaysOff;

        public List<Leave> concedii = new List<Leave>();

        public Employee(string lastname, string firstname, string dateOfBirth, string dateOfEmployment,
            int salary, int availableDaysOff) :
            base(lastname, firstname, dateOfBirth)
        {
            this.dateOfEmployement = dateOfEmployment;
            this.salary = salary;
            this.availableDaysOff = availableDaysOff;
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.firstname + " " + this.lastname + " : salariu " + salary + ", zile libere " + availableDaysOff);
        }

        private void SubstractDays(int nrOfDays)
        {
            this.availableDaysOff -= nrOfDays;
        }


        public void AddNewLeave(Leave lv)
        {

            SubstractDays(lv.duration);
            if (availableDaysOff < 0)
            {
                throw (new NegativeLeaveDays());
            }
            lv.employee = this;
            concedii.Add(lv);

        }

        public void ShowAllLeave()
        {
            foreach (Leave lv in concedii)
            {
                if (lv.startingDate.Contains("2015"))
                    Console.WriteLine(lv);
            }
        }




        public string firstname { get; set; }

        public string lastname { get; set; }
    }
}
