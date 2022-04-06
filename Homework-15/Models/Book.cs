using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_15
{
   public class Book : IEntity
    {


        public int ID { get; }
        private static int id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
       // public int ID { get; set; }
       // public  int id { get; set; }

         

        public bool IsDeleted = false;

        public Book(string name, string aurhorName,int pageCount)
        {
            Name = name;
            AuthorName = aurhorName;
            PageCount = pageCount;
            ID++;
            id += ID;
            ID = id;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {ID} \n" +
                $"Name: {Name} \n" +
                $"AuthorName: {AuthorName} \n" +
                $"PageCount: {PageCount} \n" +
                $"Isdelet: {IsDeleted}");
            Console.WriteLine("--------------");
        }


    }
}
