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
        private IRepository<HastaDetay> _HastalarRepository;
        private IUnitOfWork _HastalarUnitofWork;
        private BagislarDBEntities _dbContext;
        public HastaRepository()
        {
            _dbContext = new BagislarDBEntities();
            _HastalarRepository = new EFRepository<HastaDetay>(_dbContext);
            _HastalarUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<HastaDetay> GetHastalar()
        {
            
            return _HastalarRepository.GetAll().ToList();
        }
        public int HastaDetayEkle(HastaDetay model)
        {
            _HastalarRepository.Insert(model);
            return _HastalarUnitofWork.SaveChanges();
        }

    }
}