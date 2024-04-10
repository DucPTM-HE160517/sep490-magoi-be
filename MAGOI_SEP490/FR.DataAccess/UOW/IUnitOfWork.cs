using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FR.BusinessObjects.Models;
using FR.DataAccess.Base;

namespace FR.DataAccess.UOW
{
    public interface IUnitOfWork
    {
        TDAO GetRepository<TDAO, TEntity>() where TDAO : BaseDAO, IBaseDAO<TEntity> where TEntity : BaseModel;
        Task SaveAsync();
    }
}
