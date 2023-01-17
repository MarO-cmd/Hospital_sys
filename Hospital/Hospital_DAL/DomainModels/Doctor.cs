using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class Doctor: HospitalMember
    {
        public static decimal All_Salary = 0;     
        public decimal Salary { get; set; }
        public Patient patient { get; set; }


        public override string ToString()
        {
            return $"{base.ToString()}\n"+
                $"Salary : {Salary}\nPatient ID: {patient.Id}\nPatient Name : {patient.Name}";
        }

    }
}
