using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibraryManagement.Db;
using LibraryManagement.Model;

namespace LibraryManagement
{
   public class FineCheckAndReceiveMoney
    {
        

            public void CheckFine(LibraryContext context)
            {
                StudentInfo student = new StudentInfo();

                Console.WriteLine("Check Fine");
                Console.WriteLine("===============================");

                Console.Write("Please Enter Student Id : ");
                student.Id = int.Parse(Console.ReadLine());

                var CheckFine = context.Students.Where(x => x.Id == student.Id).SingleOrDefault();

                Console.WriteLine("\n\nYour Fine is {0} TAKA", CheckFine.FineAmount);

                Console.WriteLine("===============================");
            }






            public void ReceiveFine(LibraryContext context)
            {
                StudentInfo student = new StudentInfo();
                Console.WriteLine("Receive the Fine");
                Console.WriteLine("===============================");

                Console.WriteLine("Please Enter Student Id : ");
                student.Id = int.Parse(Console.ReadLine());


                Console.WriteLine("Please Enter Fine amount : ");
                student.FineAmount = double.Parse(Console.ReadLine());

                var CheckFine = context.Students.Where(x => x.Id == student.Id).SingleOrDefault();

                var RemainingFineBalance = CheckFine.FineAmount - student.FineAmount;

                if (RemainingFineBalance < 0) { Console.WriteLine("Sorry !! The amount cannot be negative"); }

                else
                {
                    CheckFine.FineAmount = RemainingFineBalance;
                    Console.WriteLine("Your Remaining Fine Balance is {0} Taka", RemainingFineBalance);
                    context.SaveChanges();
                }
                Console.WriteLine("===============================");
            }

        }
    }
