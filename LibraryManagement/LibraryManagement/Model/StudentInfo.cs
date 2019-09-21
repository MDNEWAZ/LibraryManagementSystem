using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement.Model
{
   public  class StudentInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double FineAmount { get; set; }
        public List<IssueBook> BookIssues { get; set; }
       public List<ReturnBook> BookReturns { get; set; }


    }
}
