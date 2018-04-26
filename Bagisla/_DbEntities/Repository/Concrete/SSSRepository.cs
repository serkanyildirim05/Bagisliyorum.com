using _DbEntities.Models;
using _DbEntities.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DbEntities.Repository.Concrete
{
    public class SSSRepository
    {
        private IRepository<SSS> _SSSRepository;
        private IUnitOfWork _SSSUnitofWork;
        private ApplicationDbContext _dbContext;
        public SSSRepository()
        {
            _dbContext = new ApplicationDbContext();
            _SSSRepository = new EFRepository<SSS>(_dbContext);
            _SSSUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<SSS> GetSSS()
        {

            return _SSSRepository.GetAll().ToList();
        }
    }
}