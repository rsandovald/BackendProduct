using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace prDTO
{
    public class ProductDTO
    {
        [StringLength(maximumLength: 20)]
        public string PRODUCT_CODE { get; set; }


        [StringLength(maximumLength: 50)]
        public string NAME { get; set; }


        [StringLength(maximumLength: 1000)]
        public string DESCRIPTION { get; set; }


        [Range(0, 1000)]
        public int QUANTITY { get; set; }

        [StringLength(maximumLength: 200)]
        public string URL_IMAGE { get; set; }


        public string CATEGORY_CODE { get; set; }

        [StringLength(maximumLength: 100)]
        public string USER_AUDIT { get; set; }

        public DateTime DATE_AUDIT { get; set; }

        public bool ACTIVE { get; set; }

    }
}
