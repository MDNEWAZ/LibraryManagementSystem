using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using LibraryManagement.Db;

namespace LibraryManagement
{
     class Program
    {
        static void Main(string[] args)
        
        {
            var context = new LibraryContext();

            Console.WriteLine("\t\t\t\t\t\t===============================\n\n\n");
            Console.WriteLine("\t\t\t\t\t\tWelcome to library system.\n\n");
            Console.WriteLine("\t\t\t\t\t\tPlease enter your choice:");
            Console.WriteLine("\t\t\t\t\t\tTo entry student information enter: 1");
            Console.WriteLine("\t\t\t\t\t\tTo entry book information enter: 2");
            Console.WriteLine("\t\t\t\t\t\tTo issue a book, enter: 3");
            Console.WriteLine("\t\t\t\t\t\tTo return a book enter: 4");
            Console.WriteLine("\t\t\t\t\t\tTo check fine, enter: 5");
            Console.WriteLine("\t\t\t\t\t\tTo receive fine, enter: 6\n");


            label:

            Console.Write("\n\t\t\t\t\t\tPlese enter your choice:");
            int ch = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            Console.WriteLine("\t\t\t\t\t\t===============================");

            switch (ch)
            {


                case 1:
                    var sb = new EntryStudent();
                    sb.EntryStudentInfo(context);
                    break;

                case 2:
                    var sbc = new EntryBook();
                    sbc.EntryBookInfo(context);
                    break;

                case 3:
                    var n = new IssueAndReturnBook();
                    n.IssueBook(context);
                    break;

                case 4:
                    var r = new IssueAndReturnBook();
                    r.ReturnBook(context);
                    break;

                case 5:
                    var cf = new FineCheckAndReceiveMoney();
                    cf.CheckFine(context);
                    break;
                case 6:
                    var cfa = new FineCheckAndReceiveMoney();
                    cfa.ReceiveFine(context);
                    break;

                default:
                    Console.WriteLine("Invalid Key Given. Please Try Again");
                    break;

                    
            }

            goto label;
        }
    }


     }


