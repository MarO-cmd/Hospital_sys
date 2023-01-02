using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class Nurse
    {
        
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string  Address { get; set; }
        public decimal Salary { get; set; }
        public static decimal All_Salary = 0;
        public Ward ward { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nAge : {Age}\n" +
                $"Salary : {Salary}\nAddress : {Address}\nWard id : {ward.Id}\nWard name : {ward.Name}";
        }

    }
}
