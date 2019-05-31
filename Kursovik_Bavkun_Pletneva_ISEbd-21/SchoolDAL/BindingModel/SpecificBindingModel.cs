using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class SpecificBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ClientId { get; set; }

        [DataMember]
        public DateTime TimeCreate { get; set; }

        [DataMember]
        public int TotalCost { get; set; }
    }
}
