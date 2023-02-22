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

        [Required(ErrorMessage = "Don't Forget to add the title!")]
        public string title { get; set; }
        [Required(ErrorMessage = "Don't Forget to add the year!")]
        public int? year { get; set; }
        [Required(ErrorMessage = "Don't Forget to add the director!")]
        public string director { get; set; }
        [Required(ErrorMessage = "Don't Forget to add the rating!")]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lent { get; set; }
        [StringLength(25)]
        public string notes { get; set; }

        // Build foreign key relationships
        public int? CategoryId { get; set; }
        public Category category { get; set; }



    }
}
