﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_HW.Entities
{
    public class BookType:BaseEntity
    {
        public IEnumerable<Book> Books { get; set;}
    }
}