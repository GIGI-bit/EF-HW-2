using EF_HW.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW.Entities
{
    public class Student:BaseEntity
    {
        public string LastName { get; set; }
        public int SchoolNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public long Phone {  get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
