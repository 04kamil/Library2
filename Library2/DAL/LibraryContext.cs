using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library2.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(): base("LibraryContext")
        {

        }

    }
}