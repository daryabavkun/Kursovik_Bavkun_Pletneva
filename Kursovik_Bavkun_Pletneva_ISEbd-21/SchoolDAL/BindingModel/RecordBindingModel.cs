using System;
using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class RecordBindingModel
    {
        public int Id { get; set; }

        [DataMember]
        public DateTime DateCreate { get; set; }
    }
}
