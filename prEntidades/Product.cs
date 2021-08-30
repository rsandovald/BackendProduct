using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prEntidades
{
    public class Product : Entity
    {

        public Product()
        {
          
            base.DATE_AUDIT = System.DateTime.Now;
            base.USER_AUDIT = "TODO:";
            base.ACTIVE = true;           
        }

        [Key]
        [StringLength(maximumLength: 20)]
        public string PRODUCT_CODE { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string NAME { get; set; }

        [Required]
        [StringLength(maximumLength: 1000)]
        public string DESCRIPTION { get; set; }

        [Required]
        [Range(0, 1000)]
        public int QUANTITY { get; set; }


        [StringLength(maximumLength: 200)]
        public string URL_IMAGE { get; set; }

        [Required]
        [StringLength(20)]
        public string CATEGORY_CODE { get; set; }

        /*

        [ForeignKey("CATEGORY_CODE")]
        public Category category { get; set; }       
       
        */
    }
}
