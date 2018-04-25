using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class ProfilRepository
    {

        private IRepository<BagisciDetay> _ProfilRepository;
        private IUnitOfWork _ProfilUnitofWork;
        private BagislarDBEntities _dbContext;
        public ProfilRepository()
        {
            _dbContext = new BagislarDBEntities();
            _ProfilRepository = new EFRepository<BagisciDetay>(_dbContext);
            _ProfilUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public int BagisciProfil(BagisciDetay detay)
        {
            _ProfilRepository.Insert(detay);
             return _ProfilUnitofWork.SaveChanges();
        }
        public BagisciDetay ProfilGetir(Guid uid)
        {
            return _ProfilRepository.Get(p => p.aspnet_Membership.UserId == uid);
        }
    }
}