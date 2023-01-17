using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Servises
{
    public interface ISorting<T>
    {
        static List<T> SortBy_Id() => new List<T> { }; 
        static List<T> SortBy_Age() => new List<T> { };
        static List<T> SortBy_Name() => new List<T> { };

        
    }
}
