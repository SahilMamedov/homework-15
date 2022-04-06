using System;

namespace Homework_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("dsf", "elesdfsstan", 433);
            Book book1 = new Book("sevgi", "sdf", 343);
            Book book2 = new Book("aaaaaaaa", "elsdfestan", 433);
            Book book3;
           // Console.WriteLine(book.ID);
            Library library = new Library();
            
            while (true)
            {
                Console.WriteLine("     Menyu   \n" +
                    "1: Add Book \n" +
                    "2: Get book by id \n" +
                    "3: Get all books \n" +
                    "4: Delete book by id \n" +
                    "5: Edit book name \n" +
                    "6: Filter by page count \n" +
                    "7: Quit" );
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    //Console.WriteLine("Kitabin adin yazin");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Muellifin adin yazin");
                    //string authorname = Console.ReadLine();
                    //Console.WriteLine("Sehife sayisin yazin");
                    //int pagecount = Convert.ToInt32(Console.ReadLine());

                    library.AddBook(book);
                    library.AddBook(book1);
                    library.AddBook(book2);
                }
                else if (num == 2)
                {
                    Console.WriteLine("Tapmaq istediyiniz kitabin ID-sini yazin");
                    int bookID = Convert.ToInt32(Console.ReadLine());
                    library.GetBookById(bookID);
                }
                else if (num == 3)
                {
                    

                }
                else if (num == 4)
                {
                    Console.WriteLine("Silmek istediyiniz Kitabin ID-sini yazin");
                    int DeletId = Convert.ToInt32(Console.ReadLine());
                    library.DeleteBookById(DeletId);

                }
                else if (num == 5)
                {
                    Console.WriteLine("Adini deyishmek istediyiniz Kitabin ID-sini yazin");
                    int EditID = Convert.ToInt32(Console.ReadLine());
                    library.EditBookName(EditID);
                }
                else if (num == 6)
                {
                    Console.WriteLine("Filterlemek istediyiniz kitablar Min ve Max sehife saylarin yazin");
                    Console.WriteLine("Minumum Sehife sayisin yazin");
                    int MinPagecount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Maxsimum Sehife sayisin yazin");
                    int MaxPagecount = Convert.ToInt32(Console.ReadLine());
                    library.FilterByPageCount(MinPagecount, MaxPagecount);   
                }
                else if (num == 0)
                {
                    break;
                }
               










            }




           


        }
    }
}
