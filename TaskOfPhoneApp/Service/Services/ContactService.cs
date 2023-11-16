using Domain.Models;
using Service.Datas;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ContactService : IContactService
    {
        public void Add(Contact contact)
        {
            AppDbContext.Contacts.Add(contact);
        }

        public List<Contact> GetAll()
        {
            return AppDbContext.Contacts.ToList();
        }

        public List<Contact> Search( string txt)
        {
           return GetAll().Where(m=>m.Name.ToLower().Contains(txt.ToLower())).ToList();
        }
    }
}
