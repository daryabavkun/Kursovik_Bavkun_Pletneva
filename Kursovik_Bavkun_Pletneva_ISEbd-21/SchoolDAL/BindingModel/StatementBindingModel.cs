using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class StatementBindingModel
    {
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Number { get; set; }
    }
}
