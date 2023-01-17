using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Servises
{
    public interface ISortPatient
    {
        static List<Patient> SortBy_Days() => throw new NotImplementedException(); 
        static List<Patient> SortBy_DaysDesc() => throw new NotImplementedException();
        static List<Patient> SortBy_Payment() => throw new NotImplementedException();
        static List<Patient> SortBy_PaymentDesc() => throw new NotImplementedException();

    }
}
