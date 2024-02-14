using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.Net_MVC_Day4.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string Title { get; set; }

        [Required]
        [MaxLength(128)]
        public string Author { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public DateTime AddedOn { get; set; }

        public Book()
        {
            AddedOn = DateTime.Now;
        }
    }
}