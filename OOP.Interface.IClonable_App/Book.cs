using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interface.IClonable_App
{
    public class Book:ICloneable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        //a deep copy
        //shalow copy
        public object Clone()
        {
            //deep copy
            //----------
            //var book = new Book();
            //book.Id = this.Id;
            //book.Title = this.Title;
            //book.Price = this.Price;
            //return book;

            return new Book()
            {
                Id = this.Id,
                Title = this.Title,
                Price = this.Price
            };

            //return this.MemberwiseClone();
        }
    }
}
