using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class StatementRecordBindingModel
    {
        public int Id { get; set; }

        [DataMember]
        public int StatementId { get; set; }

        [DataMember]
        public int RecordId { get; set; }

        [DataMember]
        public int NumberStatement { get; set; }
    }
}
