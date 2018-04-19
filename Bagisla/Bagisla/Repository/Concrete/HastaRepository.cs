using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class HastaRepository
    {
        private IRepository<Hastalar> _HastalarRepository;
        private IUnitOfWork _HastalarUnitofWork;
        private BagislarDBEntities _dbContext;
        public HastaRepository()
        {
            _dbContext = new BagislarDBEntities();
            _HastalarRepository = new EFRepository<Hastalar>(_dbContext);
            _HastalarUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<Hastalar> GetHastalar()
        {
            
            return _HastalarRepository.GetAll().ToList();
        }

    }
}