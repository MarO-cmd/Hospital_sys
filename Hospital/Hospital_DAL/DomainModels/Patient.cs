using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_DAL.DomainModels
{
    public class Patient : HospitalMember
    {
       
        public string Illness { get; set; }
        public string Entery_date { get; set; }
        public string Exit_date { get; set; }
        public int days { get; set; }
        public decimal Payment { get; set; }
        public static decimal All_Payments = 0;
        public Ward ward { get; set; }
        public Drug [] drug { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}\n" +
            $"Illness : {Illness}\nEntery Date : {Entery_date}\nExit date {Exit_date}\nHospital days : {days}\n" +
            $"Ward name : {ward.Name}\n" + $"Ward id : {ward.Id}\n" +$"Payment : {Payment}";
        }

        public void Drug_Display()
        {
            for (int i = 0; i < drug.Length; i++)
            {
                Console.WriteLine(drug[i]);
            }
            
        }


    }
}
