using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace prDTO
{
    public class ProductAddUpdDTO
    {
       
        [StringLength(maximumLength: 20)]
        public string PRODUCT_CODE { get; set; }

       
        [StringLength(maximumLength: 50)]
        public string NAME { get; set; }

       
        [StringLength(maximumLength: 1000)]
        public string DESCRIPTION { get; set; }

       
        [Range(0, 1000)]
        public int QUANTITY { get; set; }       
      
        public IFormFile IMAGE { get; set; }

        public string CATEGORY_CODE { get; set; }          


    }
}
