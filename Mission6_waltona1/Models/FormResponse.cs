using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_waltona1.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int FormId { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string director { get; set; }
        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lent { get; set; }
        [StringLength(25)]
        public string notes { get; set; }




    }
}
