using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class Specific
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        [Required]
        public DateTime TimeCreate { get; set; }

        [Required]
        public int TotalCost { get; set; }

        public virtual Client Client { get; set; }

        [ForeignKey("SpecificId")]
        public virtual List<SpecificCourse> SpecificCourse { get; set; }
    }
}
