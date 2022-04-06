using Homework_15.Enums;
using System;

namespace Homework_15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Username daxil edin");
            string username = Console.ReadLine();
            Console.WriteLine("Emailinizi daxil edin");
            string email = Console.ReadLine();
            string roll;
            do
            {
                Console.WriteLine("Role daxil edin Admin veya member kimi qeyd ola bilersiz");
                roll = Console.ReadLine();
            } while (roll!="admin"&&roll!="member");
                
                Role role = (Role)Enum.Parse(typeof(Role), roll, ignoreCase: true);
                User user = new User(username, email, role);

            
            
           


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
                    "0: Quit" );
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    if(user.Role == Role.admin)
                    {
                        Console.WriteLine("Elave etmek istediyiniz Kitabin adin yazin");
                        string name = Console.ReadLine();
                        Console.WriteLine("Muellifin adin yazin");
                        string authorname = Console.ReadLine();
                        Console.WriteLine("Sehife sayisin yazin");
                        int pagecount = Convert.ToInt32(Console.ReadLine());

                        library.AddBook(new Book(name, authorname, pagecount));
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Siz Admin deyilsiniz");
                    }
                    
                    
                }
                else if (num == 2)
                {
                    Console.WriteLine("Tapmaq istediyiniz kitabin ID-sini yazin");
                    int bookID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("*************");
                    library.GetBookById(bookID);
                }
                else if (num == 3)
                {
                    library.GetAllBooks();

                }
                else if (num == 4)
                {
                    
                    if (user.Role==Role.admin)
                    {
                        Console.WriteLine("Silmek istediyiniz Kitabin ID-sini yazin");
                        int DeletId = Convert.ToInt32(Console.ReadLine());
                        library.DeleteBookById(DeletId);
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Siz Admin deyilsiniz");
                    }
                    

                }
                else if (num == 5)
                {
                    if (user.Role == Role.admin)
                    {
                        Console.WriteLine("Adini deyishmek istediyiniz Kitabin ID-sini yazin");
                        int EditID = Convert.ToInt32(Console.ReadLine());
                        library.EditBookName(EditID);
                    }
                    else
                    {
                        Console.WriteLine("Xeta: Siz Admin deyilsiniz");
                    }
                   
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
