using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagisla.Repository.Abstract
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepositort<T>() where T : class;
        int SaveChanges(); 
    }
}
