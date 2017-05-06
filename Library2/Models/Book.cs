using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string Image { get; set; }

        public virtual Author author { get; set; }
    }
}