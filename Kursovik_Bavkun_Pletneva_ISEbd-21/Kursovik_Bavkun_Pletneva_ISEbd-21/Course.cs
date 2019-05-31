using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Cost { get; set; }

        [ForeignKey("TourId")]
        public virtual List<SpecificCourse> SpecificCourse { get; set; }

        [ForeignKey("TourId")]
        public virtual List<CourseStatement> CourseStatement { get; set; }
    }
}