using Domain.Models;
using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfPhoneApp.Controllers
{
    public class ContactController
    {
        private readonly IContactService _contactService;

        public ContactController()
        {
            _contactService = new ContactService();
        }

        public void Add()
        {
            Console.WriteLine("Add Name:");
            string name=Console.ReadLine();
            Console.WriteLine("Add Surname:");
            string surname=Console.ReadLine();
            Console.WriteLine("Add phoneNum:");
            string phoneNum=Console.ReadLine();
            Contact contact = new Contact()
            {
                Name = name,
                Surname = surname,
                PhoneNum = phoneNum
            };
            _contactService.Add(contact);
        }

        public void GetAll()
        {
            var datas=_contactService.GetAll();

            foreach (var item in datas)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.PhoneNum);
            }
        }
    }
}
