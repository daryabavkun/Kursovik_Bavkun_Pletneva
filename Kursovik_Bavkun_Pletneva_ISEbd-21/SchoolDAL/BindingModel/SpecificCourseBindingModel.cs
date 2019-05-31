using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class SpecificCourseBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int SpetificId { get; set; }

        [DataMember]
        public int CourseId { get; set; }

        [DataMember]
        public DateTime DateStatement { get; set; }

        [DataMember]
        public DateTime DateBegin { get; set; }

        [DataMember]
        public DateTime DateEnd { get; set; }
    }
}
