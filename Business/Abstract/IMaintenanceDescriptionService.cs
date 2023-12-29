using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaintenanceDescriptionService
    {
        IDataResult<List<MaintenanceDescription>> GetAll();
        IDataResult<MaintenanceDescription> GetById(int id);

        IResult Add(MaintenanceDescription maintenanceDescription);
        IResult Update(MaintenanceDescription maintenanceDescription);
        IResult Delete(MaintenanceDescription maintenanceDescription);
    }
}
