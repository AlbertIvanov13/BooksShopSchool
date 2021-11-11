using System;
using System.Linq;
using System.Collections.Generic;
using BooksShopSchool.Data;

namespace BooksShopSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BooksShopSchoolContext();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
