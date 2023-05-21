using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook.Core.Contacts
{
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public ContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _context.Contacts.Include(c => c.Phones);
        }
        public void AddContact(Contact contact)
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(Contact contact)
        {
            throw new NotImplementedException();
        }


        public Contact GetContactById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}