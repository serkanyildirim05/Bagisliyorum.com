using _DbEntities.Models;
using _DbEntities.Repository.Abstract;
using _DbEntities.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _DbEntities.Repository.Concrete
{
    public class UserRepository
    {


        private IRepository<ApplicationUser> _UserRepository;
        private IUnitOfWork _UserUnitofWork;
        private ApplicationDbContext _dbContext;
        public UserRepository()
        {
            _dbContext = new ApplicationDbContext();
            _UserRepository = new EFRepository<ApplicationUser>(_dbContext);
            _UserUnitofWork = new EFUnitOfWork(_dbContext);
        }
        public ApplicationUser GetUserById(string Uid)
        {
            return _UserRepository.Get(x=>x.Id==Uid);
        }    
    
    }
}