using System;
using System.Collections.Generic;

namespace Homework_15
{
    class Library //: IEntity
    {
        public int ID { get; }

        public int BookLimit = 10;
        private List<Book> Books = new List<Book>();
    


        public void AddBook(Book book)
        {
            if (Books.Count == 0)
            {
                Books.Add(book);
            }
            foreach (var item in Books)
            {
                if (item.IsDeleted == false && item.Name == book.Name)
                {

                    throw new AlreadyExistsException("bu adda kitabimiz var");

                }

                else if (BookLimit > 0)
                {
                    Books.Add(item);
                }
                else
                {
                    throw new CapacityLimitException("Capacityniz doludur");
                }

            }

        }
        public Book GetBookById(int? id)
        {
            foreach (Book book in Books)
            {
                if (book.IsDeleted == false && book.ID == id)
                {
                    book.ShowInfo();
                    return book;
                }
                else if (id == null)
                {
                    throw new NullReferenceException("ID-ni bosh gondermisiz");
                }

            }
            return null;
        }
        List<Book> Getallbooks = new List<Book>();
        //public Book GetAllBooks()
        //{
        //    foreach (Book book in Books)
        //    {
                

        //    }
        //    return Getallbooks;
        //}
        public void DeleteBookById(int ? id)
        {
            foreach (Book book in Books)
            {
                if(book.ID==id && book.IsDeleted == false)
                {
                    book.IsDeleted = true;
                }
                else if (id == null)
                {
                    throw new NullReferenceException("Id-ni bosh gondermisiz");
                }
                else
                {
                    throw new NotFoundException("Bele bir kitab tapilmadi");
                }
            }

        }
        public void EditBookName(int? id)
        {
            foreach (Book book in Books)
            {
                if (book.ID == id)
                {
                    book.Name = Convert.ToString(Console.ReadLine());
                }
                else if (id == null)
                {
                    throw new NullReferenceException("Id-ni bosh gondermisiz");
                }
                else
                {
                    throw new NotFoundException("bele bir kitab tapilmadi");
                }
            }
        }
        public void FilterByPageCount(int minpagecount,int maxpagecount)
        {
            foreach (Book book in Books)
            {
                if (book.PageCount <= minpagecount && book.PageCount <= maxpagecount && book.IsDeleted==false)
                {
                    Console.WriteLine($"Filtirlenmish \n " +
                        $"ID: {book.ID} \n" +
                        $"Name: {book.Name} \n" +
                        $"AuthorName: {book.AuthorName} \n" +
                        $"PageCount: {book.PageCount}");
                }
            }


        }


    }
}

