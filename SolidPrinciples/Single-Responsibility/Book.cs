using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    public class Book
    {
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public bool Isbn { get; set; }
        public Book(string title,string authorName,int year,int price,bool isbn)
        {
            this.Title = title;
            this.AuthorName = authorName;
            this.Year = year;
            this.Price = price;
            this.Isbn = isbn;
        }
    }
}
