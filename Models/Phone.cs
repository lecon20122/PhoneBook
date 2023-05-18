using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Number { get; set; } = null!;
        public int ContactId { get; set; }
        public Contact Contact { get; set; } = new Contact();
        public string? Address { get; set; }
    }
}