using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Model
{
    public class ReturnBook
    {

        public int StudentId { get; set; }
        public StudentInfo Student { get; set; }
        public int BookId { get; set; }
        public BookInfo Book { get; set; }
        public string BookBarCode { get; set; }
        public DateTime ReturnDate { get; set; }
       
    }
}
