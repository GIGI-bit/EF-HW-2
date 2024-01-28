using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW.Entities
{
    public class Book:BaseEntity
    {
        public int PageCount { get; set; }

        public IEnumerable<Student> Students { get; set; }
        public Author Author { get; set; }
        public BookType BookType { get; set; }
    }
}
