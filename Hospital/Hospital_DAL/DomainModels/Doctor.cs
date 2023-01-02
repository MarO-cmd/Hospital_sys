using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class Doctor
    {
        public static decimal All_Salary = 0;
        public string Name { get; set; }
        public int  Age { get; set; }
        public string Id { get; set; }
        public decimal Salary { get; set; }
        public Patient patient { get; set; }


        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nAge : {Age}\n" +
                $"Salary : {Salary}\nPatient ID: {patient.Id}\nPatient Name : {patient.Name}";
        }

    }
}
