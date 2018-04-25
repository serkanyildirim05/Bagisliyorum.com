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
        public BagisciDetay GetBagisciDetay(string email) {
            return _BagiscilarRepository.Get(m=>m.aspnet_Membership.LoweredEmail==email);
        }
        public BagisciDetay UpdateDetay(BagisciDetay entity)
        {
            entity.aspnet_Membership.UserId= entity.ID;
            _BagiscilarRepository.Updete(entity);
            _BagiscilarUnitofWork.SaveChanges();

            return _BagiscilarRepository.Get(m=>m.ID==entity.ID);
        }
    }
}