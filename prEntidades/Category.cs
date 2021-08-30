using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prEntidades
{
    public class Category
    {
        [Key]
        [StringLength(maximumLength: 20)]
        public string CATEGORY_CODE { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(maximumLength: 1000)]
        public string DESCRIPTION { get; set; }

        [Required]        
        public bool ACTIVE { get; set; }
     
        /*
        public ICollection<Product> Products { get; set; }
        */
    }
}
