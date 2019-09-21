using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Db;
using LibraryManagement.Model;

namespace LibraryManagement
{
    public class EntryBook

    {
        public void EntryBookInfo(LibraryContext context)
        {
            BookInfo book = new BookInfo();
            Console.WriteLine("===============================");
            Console.WriteLine("Entry Book Information Center");

            Console.Write("Please enter Book Title: ");
            book.Title = Console.ReadLine();

            Console.Write("Please enter Book Author: ");
            book.Author = Console.ReadLine();

            Console.Write("Please enter Book Edition: ");
            book.Edition = Console.ReadLine();

            Console.Write("Please enter Barcode of the book: ");
            book.BarCode = Console.ReadLine();

            Console.Write("Please enter Copy Count of the book: ");
            book.CopyCount = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================");

            context.Books.Add(new BookInfo()
            {
                Author = book.Author,
                Edition = book.Edition,
                Title = book.Title,
                BarCode = book.BarCode,
                CopyCount = book.CopyCount
            });
            context.SaveChanges();
        }
    }
}
