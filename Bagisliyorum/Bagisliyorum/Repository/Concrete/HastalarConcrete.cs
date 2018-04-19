using Bagisliyorum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bagisliyorum.Repository.Concrete
{
    public class HastalarConcrete
    {
        public Hastalar HastaGetir()
        {
            using (BagislarDBEntities db = new BagislarDBEntities())
            {
                return db.Hastalars.OrderByDescending(p => p.Hasta_No).FirstOrDefault();
            }
        }
    }
}