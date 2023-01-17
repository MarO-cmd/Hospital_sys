using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class HospitalMember
    {
        public string Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}\nName : {Name}\nAge : {Age}";
        }
    }
}
