using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
#pragma warning disable CS0219
namespace ConsoleApp2
{
 
    class Book
    {
        public int bookId;
        public string bookName;
        public int bookPrice;
        public int bookCount;
        public int x;
    }
    class Newspaper
    {
        public int newspaperId;
        public string newspaperName;
        public int newspaperPrice;
        public int newspaperCount;
        public int x;
    }
   
    class BorrowDetails
    {

       
        public string userName;
        
        public int borrowBookId;
        public DateTime borrowDate;
        public int borrowCount;
    }
    class BorrowNewspaper
    {
       
        public string userName;

        public int borrowNewspaperId;
        public DateTime borrowDate;
        public int borrowCount;
    }

    class Program
    {
        



        public static void Main(string[] args)
        {

            Program obj = new Program();
            obj.main();

        }
        public void main()
        {
            try
            {
                Console.WriteLine("**************************MAIN MENU****************");
                Console.WriteLine("Choose The options by entering charecter:");

                Console.WriteLine("------------->a.Books\n" + "" +
                                  "------------->b.Newspaper\n" + "" +
                                  "-------------->c.Close");
                char ch;
                Console.WriteLine("Enter an alphabet");
                ch = Convert.ToChar(Console.ReadLine());
                string ch2 = Convert.ToString(ch);
                Librarian object1 = new Librarian();

                Program pobj = new Program();
                
                if (ch=='a'|| ch=='b' || ch=='c')
                {
                    switch (Char.ToLower(ch))
                    {
                        case 'a':


                            pobj.demo();
                            break;
                        case 'b':


                            pobj.demon();
                            break;
                        case 'c':
                            Console.WriteLine("*********************Thank you********************");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("string has not mathed please check");
                    main();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Given input not matched please enter again");
                main();
            }

        }
        public void demo()
        {
            Console.WriteLine("***************************Books************************");
            Console.WriteLine("Choose The option by entering character");

            Console.WriteLine("---------->a.Librarian\n" + " " +
                              "---------->b.Borrower\n" + " " +
                              "---------->c.Close");

            char ch;
            Console.WriteLine("Enter an alphabet");
            ch = Convert.ToChar(Console.ReadLine());
            Librarian object1 = new Librarian();
            Borrower object2 = new Borrower();
            if (ch == 'a' || ch == 'b' || ch == 'c')
            {

                switch (Char.ToLower(ch))
                {
                    case 'a':
                        Console.WriteLine("**************************Librarian*******************");
                        Console.WriteLine("-------------------------------------------------------");
                        object1.Librarian1();
                        break;
                    case 'b':
                        Console.WriteLine("**************************Borrower********************");
                        Console.WriteLine("-------------------------------------------------------");
                        object2.Borrower1();
                        break;
                    case 'c':

                        Console.WriteLine("-------------------------------------------------------");
                        main();
                        break;

                }
            }
            else
            {
                Console.WriteLine("string has not matched please re-enter");

                demo();
            }
        }
        public void demon()
        {
            Librarian object1 = new Librarian();
            Borrower object2 = new Borrower();
            Console.WriteLine("*******************************Newspaper*******************************");
            Console.WriteLine("Choose The option by entering character");

            Console.WriteLine("--------->a.Librarian Newspaper\n" + " " + "" +
                             "----------->b.Borrower Newspaper\n" + " " +
                             "------------>c.Close");

            char ch;
            Console.WriteLine("Enter an alphabet");

            ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'b' || ch == 'c')
            {

                switch (Char.ToLower(ch))
                {
                    case 'a':

                        object1.Newspaper();
                        break;
                    case 'b':
                        Console.WriteLine("---------------------------->>>Borrower<<<------------------------");
                        object2.Newspaperborrower();
                        break;
                    case 'c':

                        Console.WriteLine("-------------------------------------------------------");
                        demo();
                        break;
                }
            }
            else
            {
                Console.WriteLine("string has not matched please re-enter");
                demon();
            }

        }


    }
}