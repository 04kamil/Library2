using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library2.Models
{
    public class Author
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AuthorID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Life { get; set; }
        public string Descryption { get; set; }

    }
}