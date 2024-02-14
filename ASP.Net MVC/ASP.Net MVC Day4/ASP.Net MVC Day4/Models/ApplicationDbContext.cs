using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Day4.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        public System.Data.Entity.DbSet<ASP.Net_MVC_Day4.Models.BookFormViewModel> BookFormViewModels { get; set; }
    }
}