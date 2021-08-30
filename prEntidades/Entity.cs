using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace prEntidades
{
    public class Entity
    {
        
        [StringLength(maximumLength: 100)]
        public string USER_AUDIT { get; set; }

       
        public DateTime DATE_AUDIT { get; set; }

        public bool ACTIVE { get; set; }

    }
}
