using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BLL.Servises
{
    public interface IHumanCRUD<T>
    {

        // Create , Reterive , Update , Delete

        #region CRUD OPS
        
        void Add();
        void Update(string Id);
        void Delete(string Id);
        List<T> GetAll();
        T GetById(string Id);

        #endregion
    }
}
