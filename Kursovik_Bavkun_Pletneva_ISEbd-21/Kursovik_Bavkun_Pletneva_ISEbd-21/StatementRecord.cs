using System.ComponentModel.DataAnnotations;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class StatementRecord
    {
        public int Id { get; set; }

        public int StatementId { get; set; }

        public int RecordId { get; set; }

        [Required]
        public int NumberStatement { get; set; }

        public virtual Statement Statement { get; set; }

        public virtual Record Record { get; set; }
    }
}
