using Hospital_DAL.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Servises
{
    public interface ISortDoctor
    {
        static List<Doctor> SortBy_Salary() => new List<Doctor> { };
        static  List<Doctor> SortBy_SalaryDesc() => new List<Doctor> { };


    }
}
