using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDAL.BindingModel;
using SchoolDAL.ViewModel;

namespace SchoolDAL.Interfaces
{
    public interface ISpecific
    {
        List<SpecificViewModel> GetList();

        void CreateTravel(SpecificBindingModel);

        void Reservation(SpecificBindingModel);
    }
}
