using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class DoktorRepository
    {
        private IRepository<Doktorlar> _DoktorlarRepository;
        private IUnitOfWork _DoktorlarUnitofWork;
        private BagislarDBEntities _dbContext;
        public DoktorRepository()
        {
            _dbContext = new BagislarDBEntities();
            _DoktorlarRepository = new EFRepository<Doktorlar>(_dbContext);
            _DoktorlarUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<Doktorlar> GetDoktorlar()
        {

            return _DoktorlarRepository.GetAll().ToList();
        }
    }
}