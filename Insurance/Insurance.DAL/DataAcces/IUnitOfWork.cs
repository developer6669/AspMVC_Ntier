using Insurance.DAL.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.DAL.DataAccess
{
    public interface IUnitOfWork<out TContext>
        where TContext : DatabaseContext, new()
    {
        TContext Context { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
