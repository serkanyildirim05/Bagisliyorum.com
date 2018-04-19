using Bagisla.Models;
using Bagisla.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisla.Repository.Concrete
{
    public class MesajlarRepository
    {
        private IRepository<Mesajlar> _MesajlarRepository;
        private IUnitOfWork _MesajlarUnitofWork;
        private BagislarDBEntities _dbContext;
        public MesajlarRepository()
        {
            _dbContext = new BagislarDBEntities();
            _MesajlarRepository = new EFRepository<Mesajlar>(_dbContext);
            _MesajlarUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public List<Mesajlar> Get_Mesajlar()
        {

            return _MesajlarRepository.GetAll().ToList();
        }
        public int Add_Mesajlar(Mesajlar entity)
        {
           _MesajlarRepository.Insert(entity);
            return _MesajlarUnitofWork.SaveChanges();

        }
    }
}