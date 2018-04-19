using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class SSSRepository
    {
        private IRepository<SSS> _SSSRepository;
        private IUnitOfWork _SSSUnitofWork;
        private BagislarDBEntities _dbContext;
        public SSSRepository()
        {
            _dbContext = new BagislarDBEntities();
            _SSSRepository = new EFRepository<SSS>(_dbContext);
            _SSSUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<SSS> GetSSS()
        {

            return _SSSRepository.GetAll().ToList();
        }
    }
}