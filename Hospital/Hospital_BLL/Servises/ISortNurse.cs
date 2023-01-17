using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Servises
{
    public interface ISortNurse
    {
       static List<Nurse> SortBy_Salary() => new List<Nurse> { };
       static List<Nurse> SortBy_SalaryDesc() => new List<Nurse> { };
       static List<Nurse> SortBy_Adress() => new List<Nurse> { };


    }
}
