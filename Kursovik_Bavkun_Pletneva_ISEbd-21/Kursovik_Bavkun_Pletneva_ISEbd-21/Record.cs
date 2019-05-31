using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kursovik_Bavkun_Pletneva_ISEbd_21
{
    public class Record
    {
        public int Id { get; set; }

        public DateTime DateCreate { get; set; }

        [ForeignKey("RequestId")]
        public virtual List<StatementRecord> StatementRecord { get; set; }
    }
}
