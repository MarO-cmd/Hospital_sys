using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class Drug
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Dosage { get; set; }


        public override string ToString()
        {
            return $"Drug Name : {Name}\nDrug Code : {Code}\nDrug Dosage : {Dosage}";
        }
    }
}
