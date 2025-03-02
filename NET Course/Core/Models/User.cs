using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    internal class User
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new List<Book>();
        UserRole Role { get; set; }
    }
}
