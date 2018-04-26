using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class BagisciRepository
    {


        private IRepository<BagisciDetay> _BagiscilarRepository;
        private IUnitOfWork _BagiscilarUnitofWork;
        private BagislarDBEntities _dbContext;
        public BagisciRepository()
        {
            _dbContext = new BagislarDBEntities();
            _BagiscilarRepository = new EFRepository<BagisciDetay>(_dbContext);
            _BagiscilarUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public void BagisciDetayEkle(BagisciDetay detay)
        {
            _BagiscilarRepository.Insert(detay);
            _BagiscilarUnitofWork.SaveChanges();
         
        }
    }
}