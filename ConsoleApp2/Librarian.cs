using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Librarian
    {
        static Book book = new Book();
        static Newspaper newspaper = new Newspaper();
        static List<Book> bookList { get; set; } = new List<Book>()
        {
            new Book{bookId=1,bookName="vidyalaya",bookCount=2,bookPrice=236},
            new Book{bookId=2,bookName="friction",bookCount=4,bookPrice=235},
            new Book{bookId=3,bookName="rich dad poor dad",bookCount=2,bookPrice=233},
            new Book{bookId=4,bookName="happy endings",bookCount=3,bookPrice=233},
        };
        static List<BorrowDetails> borrowList { get; set; } = new List<BorrowDetails>()
        {
             new BorrowDetails{borrowBookId=1,borrowCount=6},
             new BorrowDetails{borrowBookId=4,borrowCount=55},
             new BorrowDetails{borrowBookId=3,borrowCount=4},
             new BorrowDetails{borrowBookId=5,borrowCount=3},

        };
        static BorrowDetails borrow = new BorrowDetails();
        static BorrowNewspaper borrown = new BorrowNewspaper();
        static List<BorrowNewspaper> borrownewspaperList { get; set; } = new List<BorrowNewspaper>();
        static List<Newspaper> newspaperList { get; set; } = new List<Newspaper>() {
            new Newspaper { newspaperId=1,newspaperName="Hindustantimes",newspaperCount=2,newspaperPrice=132},
            new Newspaper { newspaperId=3,newspaperName="Time newyork",newspaperCount=2,newspaperPrice=1234},
            new Newspaper { newspaperId=2,newspaperName="Ennadu",newspaperCount=2,newspaperPrice=123} ,
            new Newspaper { newspaperId=4,newspaperName="Bussineelines",newspaperCount=2,newspaperPrice=123}
        };


        public void paperSearch()
        {
            Program obj1 = new Program();
            foreach (Newspaper obj in newspaperList)
            {
                Console.WriteLine("News paper id:{0},Name:{1},Newspapercount:{2},NewspaperPrice:{3}", obj.newspaperId, obj.newspaperName, obj.newspaperCount, obj.newspaperPrice);
            }
            obj1.demon();
        }
        public void BookSearch()
        {
            Program obj1 = new Program();
            foreach (Book obj in bookList)
            {
                Console.WriteLine("Book id:{0},BookName:{1},Book_count:{2},Bookprice:{3}", obj.bookId, obj.bookName, obj.bookCount, obj.bookPrice);
            }
            obj1.demo();
        }
        public void BarrrowNewslist()
        {
            Program obj1 = new Program();
            foreach (BorrowNewspaper obj in borrownewspaperList)
            {
                Console.WriteLine("BnewspaperId:{0},BnewCount:{1},BNewsDate:{2}", obj.borrowNewspaperId, obj.borrowCount, obj.borrowDate);
            }
            obj1.demon();
        }

        public void Borrowbooklist()
        {
            Program obj1 = new Program();
            foreach (BorrowDetails obj in borrowList)
            {
                Console.WriteLine("BarrowBookId:{0},BorrowCount:{1}", obj.borrowBookId, obj.borrowCount);
            }
            obj1.demo();
        }
        Program obj = new Program();


        public void Newspaper()
        {
            Program obj = new Program();
            Console.WriteLine("---------------------------->>>LIBRARIAN NEWSPAPER MENU<<-----------------------");
            Console.WriteLine(
                "1)-------------->Add Newspaper\n" + "" +
                "2)--------------->Delete Newspaper\n" +
                "3)--------------->show avalible news papers\n" +
                "4)----------------> Colse");
            Console.WriteLine("Choose your option from menu :");
            try
            {
                int option = int.Parse(Console.ReadLine());
                if (option == 1 || option == 2 || option == 3 || option == 4)
                {
                    if (option == 1)
                    {
                        GetNewspaper();
                    }
                    else if (option == 2)
                    {
                        RemoveNewspaper();
                    }
                    else if (option == 3)
                    {
                        paperSearch();
                    }
                    else if (option == 4)
                    {
                        obj.demon();
                    }
                }
                else
                {
                    Console.WriteLine("Entere number is not matched please re-enter");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Entered number deosn't match please enter it again");
                Newspaper();
            }
        }
        public static void GetNewspaper()
        {
            Program obj = new Program();
            Console.WriteLine("Newspaper Id:{0}", newspaper.newspaperId = newspaperList.Count + 1);
            Console.Write("newspaper Name:");

            newspaper.newspaperName = Console.ReadLine();
            Console.Write("Newspaper Price:");

            newspaper.newspaperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper:");

            newspaper.x = newspaper.newspaperCount = int.Parse(Console.ReadLine());
            newspaperList.Add(newspaper);

            Console.WriteLine("Newspaper Added Successfully");
            Console.WriteLine("-------------------------------------------------------");
            obj.demon();
        }
        public static void RemoveNewspaper()
        {
            Librarian obj = new Librarian();
            Console.Write("Enter Newspaper id to be deleted : ");
            int Del = int.Parse(Console.ReadLine());
            int Remove_newspaper = 0;
            if (newspaperList.Exists(m => m.newspaperId == Del))
            {
                newspaperList.RemoveAt(Del - 1);
                Console.WriteLine("Newspaper id - {0} has been deleted", Del);
                Remove_newspaper += 1;
                obj.Newspaper();
            }
            else
            {
                Console.WriteLine("Invalid Newspaper id");
            }

            newspaperList.Add(newspaper);
        }


        public void Librarian1()
        {
            Program obj = new Program();
            Console.WriteLine("\n*********************LIBRARIAN BOOK MENU***************\n" +
                "1)---------->Add book\n" +
                "2)----------->Delete book\n" +
                "3)------------>Search book\n" +
                "4)------------>Book list\n" + "" +
                "5)------------>close");

            Console.Write("Choose your option from menu :");
            try
            {
                int option = int.Parse(Console.ReadLine());


                if (option == 1 || option == 2 || option == 3 || option == 4 || option == 5)
                {

                    if (option == 1)
                    {
                        GetBook();
                    }
                    else if (option == 2)
                    {
                        RemoveBook();
                    }
                    else if (option == 3)
                    {
                        SearchBook();
                    }
                    else if (option == 4)
                    {
                        BookSearch();
                    }
                    else if (option == 5)
                    {

                        obj.demo();
                    }
                }

                else
                {
                    Console.WriteLine("Entere number is not matched please re-enter");
                    Librarian1();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" You have entered worng please enter angain");
                Librarian1();
            }
        }
        public static void GetBook()
        {
            Program obj = new Program();
            Console.Write("Book Id:");
            book.bookId = int.Parse(Console.ReadLine());
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            bookList.Add(book);
            Console.WriteLine("Book Added Successfully");
            Console.WriteLine("-------------------------------------------------------");
            obj.demo();
        }
        public static void RemoveBook()
        {
            Program obj = new Program();
            Console.Write("Enter Book id to be deleted : ");

            int Del = int.Parse(Console.ReadLine());
            int Remove_book = 0;

            if (bookList.Exists(m => m.bookId == Del))
            {
                bookList.RemoveAt(Del - 1);
                Console.WriteLine("Book id - {0} has been deleted", Del);
                Remove_book += 1;
                obj.demo();
            }
            else
            {
                Console.WriteLine("Invalid Book id");
            }


        }
        public static void SearchBook()
        {
            Program obj = new Program();
            Console.Write("Search by BOOK id :");
            int find = int.Parse(Console.ReadLine());

            if (bookList.Exists(m => m.bookId == find))
            {
                foreach (Book searchId in bookList)
                {
                    if (searchId.bookId == find)
                    {
                        Console.WriteLine("Book id :{0}\n" +
                        "Book name :{1}\n" +
                        "Book price :{2}\n" +
                        "Book Count :{3}", searchId.bookId, searchId.bookName, searchId.bookPrice, searchId.bookCount);
                        obj.demo();
                    }
                }
            }
            else
            {
                Console.WriteLine("Book id {0} not found", find);
                obj.demo();
            }
        }
        public static void Borrow()
        {
            Program obj3 = new Program();
            Borrower obj = new Borrower();
            Librarian ob1 = new Librarian();
            Console.Write(" Book Name :");
            borrow.userName = Console.ReadLine();
            Console.Write("Book id :");

            borrow.borrowBookId = int.Parse(Console.ReadLine());
            Console.Write("Number of Books!! : ");
            borrow.borrowCount= int.Parse(Console.ReadLine());
            borrow.borrowDate = DateTime.Now;
            Console.WriteLine("Date - {0} and Time - {1}", borrow.borrowDate.ToShortDateString(), borrow.borrowDate.ToShortTimeString());


            if (bookList.Exists(m => m.bookId == borrow.borrowBookId))
            {

                borrowList.Add(borrow);
               

                if (bookList.Exists(m => m.bookId == borrow.borrowBookId))
                {
                    int Remove_book = 0;
                    bookList.RemoveAt(borrow.borrowBookId - 1);
                    

                    Remove_book += 1;
                    obj3.demo();
                }
            }
            
            else
            {
                Console.WriteLine("Book id {0} not found", borrow.borrowBookId);
            }

        }
        public static void BorrowNewspaper()
        {
            Program obj = new Program();

            Console.Write("Name :");
            borrown.userName = Console.ReadLine();

            Console.Write("Newspaper id :");
            borrown.borrowNewspaperId = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspapers : ");
            borrown.borrowCount = int.Parse(Console.ReadLine());

            borrown.borrowDate = DateTime.Now;


            if (newspaperList.Exists(m => m.newspaperId == borrown.borrowNewspaperId))
            {
                borrownewspaperList.Add(borrown);
                int Remove_newspaper = 0;
                newspaperList.RemoveAt(borrown.borrowNewspaperId - 1);
                
                Remove_newspaper += 1;
                obj.demon();
               


            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", borrown.borrowNewspaperId);
                obj.demon();
            }
            
        }
        public static void ReturnNewspaper()
        {
            Program obj = new Program();
            newspaper.newspaperId= int.Parse(Console.ReadLine());   
            newspaper.newspaperName = Console.ReadLine();
            Console.Write("Newspaper Price:");

            newspaper.newspaperPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Newspaper:");

            newspaper.x = newspaper.newspaperCount = int.Parse(Console.ReadLine());
            


            if (newspaperList.Exists(y => y.newspaperId ==  newspaper.newspaperId))
            {
                newspaperList.Add(newspaper);
                
                borrownewspaperList.RemoveAt(newspaper.newspaperId - 1);

                obj.demon();
            }
            else
            {
                Console.WriteLine("Newspaper id {0} not found", newspaper.newspaperId);
                obj. demon();
            }
        }
        public static void ReturnBook()
        {
            Program obj = new Program();
            Console.WriteLine("Enter following details :");

            Console.Write("Book Id:");
            book.bookId = int.Parse(Console.ReadLine());
            Console.Write("Book Name:");
            book.bookName = Console.ReadLine();
            Console.Write("Book Price:");
            book.bookPrice = int.Parse(Console.ReadLine());
            Console.Write("Number of Books:");
            book.x = book.bookCount = int.Parse(Console.ReadLine());
            if (borrowList.Exists(y => y.borrowBookId == book.bookId))
            {
                bookList.Add(book);
                int Remove_book = 0;
                borrowList.RemoveAt(book.bookId - 1);
                
                Remove_book += 1;
               
                obj.demo();

            }
            else
            {
                Console.WriteLine("Book id {0} not found", book.bookId);
                obj.demo();
            }
        }

    }
}
