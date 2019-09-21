using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Db;
using LibraryManagement.Model;

namespace LibraryManagement
{
    public class EntryStudent
    {

        public void EntryStudentInfo(LibraryContext context)
        {
            StudentInfo student = new StudentInfo();
            Console.WriteLine("===============================");
            Console.WriteLine("Entry Student Information center");
            Console.Write("Please enter student Id: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Please enter student Name: ");
            student.Name = Console.ReadLine();

            student.FineAmount = 0;
            Console.WriteLine("===============================");

            context.Students.Add(new StudentInfo()
            {
                Id = student.Id,
                Name = student.Name,
                FineAmount = 0
            });
            context.SaveChanges();
        }

    }
}
