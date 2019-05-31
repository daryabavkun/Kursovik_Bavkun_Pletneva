using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SchoolDAL.BindingModel
{
    [DataContract]
    public class CourseStatementBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ReservationId { get; set; }

        [DataMember]
        public int TourId { get; set; }

        [DataMember]
        public int NumberReservations { get; set; }
    }
}
