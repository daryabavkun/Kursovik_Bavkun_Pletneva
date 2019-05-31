using System;
using System.ComponentModel.DataAnnotations;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class SpecificCourse
    {
        public int Id { get; set; }

        public int SpecificId { get; set; }

        public int CourseId { get; set; }

        public DateTime DateStatement { get; set; }

        [Required]
        public DateTime DateBegin { get; set; }

        [Required]
        public DateTime DateEnd { get; set; }

        public virtual Specific Specific { get; set; }

        public virtual Course Course { get; set; }
    }
}
