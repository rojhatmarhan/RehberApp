using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class ContactManager
    {
        GenericRepository<Contact> _repo = new GenericRepository<Contact>();

        public List<Contact> GetAll()
        {
            return _repo.GetAll().Include(x => x.Details).ToList();
        }

        public void Add(Contact p)
        {
            if (p != null)
            {
                _repo.Insert(p);
            }
        }

    }
}
