using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket
{
    internal class Book
    {
        public int Id;
        public string Name;
        public int PageSize;
        public string Genre;
        public double Price;
        public int InStock;

        public Book(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public Book(int id,string name,int pageSize,double price,int inStock) : this(id, name)
        {
            Price = price;
            InStock = inStock;
            PageSize = pageSize;
        }

        public Book(int id,string name,int pageSize,double price, int inStock, string genre) : this(id, name, pageSize, price, inStock)
        {
            Genre = genre;
        }




    }
}
