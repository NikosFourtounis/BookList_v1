using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookList_v1.Models
{
    public class Book
    {
        public int Id{ get; set; }

        [Required]
        public String Name{ get; set; }
    }
}
