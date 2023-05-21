using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneBook.Core.Contacts;
using PhoneBook.ViewModels;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public IActionResult Index()
        {
            var contacts = _contactRepository.GetAllContacts();
            return View(new ContactIndexViewModel(contacts));
        }
    }
}