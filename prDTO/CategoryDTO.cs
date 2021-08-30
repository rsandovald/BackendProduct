using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace prDTO
{
    public class CategoryDTO
    {
     
        [StringLength(maximumLength: 20)]
        public string CATEGORY_CODE { get; set; }

        
        [StringLength(maximumLength: 50)]
        public string NAME { get; set; }

       
        [StringLength(maximumLength: 1000)]
        public string DESCRIPTION { get; set; }

        public bool ACTIVE { get; set; }

    }
}
