using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Datas
{
    public static class AppDbContext
    {
        public static List<Contact>Contacts = new List<Contact>();

        static AppDbContext()
        {
            Contacts = new List<Contact>();
        }
    }
}
