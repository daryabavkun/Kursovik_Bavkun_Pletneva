using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class Statement
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Number { get; set; }

        [ForeignKey("StatementId")]
        public virtual List<CourseStatement> CourseStatement { get; set; }

        [ForeignKey("StatementId")]
        public virtual List<Statement> StatementRecord { get; set; }
    }
}
