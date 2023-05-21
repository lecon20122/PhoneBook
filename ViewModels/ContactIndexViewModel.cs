using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhoneBook.Models;

namespace PhoneBook.ViewModels
{
    public class ContactIndexViewModel
    {
        public IEnumerable<Contact> Contacts { get; set; }

        public ContactIndexViewModel(IEnumerable<Contact> contacts)
        {
            Contacts = contacts;
        }
    }
}