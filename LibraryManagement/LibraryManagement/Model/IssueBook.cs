using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Model
{
   public class IssueBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public StudentInfo Student { get; set; }
        public int bookId { get; set; }
        public BookInfo book { get; set; }
        public string BookBarCode { get; set; }
        public DateTime IssueDate { get; set; }
    }
}
