using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MaintenanceDescriptionManager : IMaintenanceDescriptionService
    {
        IMaintenanceDescriptionDal _maintenanceDescriptionDal;
        public MaintenanceDescriptionManager(IMaintenanceDescriptionDal maintenanceDescriptionDal)
        {
            _maintenanceDescriptionDal = maintenanceDescriptionDal;
        }
        public IResult Add(MaintenanceDescription maintenanceDescription)
        {
            _maintenanceDescriptionDal.Add(maintenanceDescription);
            return new SuccessResult();
        }

        public IResult Delete(MaintenanceDescription maintenanceDescription)
        {
            return new SuccessResult();
        }

        public IDataResult<List<MaintenanceDescription>> GetAll()
        {
            return new SuccessDataResult<List<MaintenanceDescription>>(_maintenanceDescriptionDal.GetAll());
        }

        public IDataResult<MaintenanceDescription> GetById(int id)
        {
            return new SuccessDataResult<MaintenanceDescription>(_maintenanceDescriptionDal.Get(m => m.MaintenanceDescriptionId == id));
        }

        public IResult Update(MaintenanceDescription maintenanceDescription)
        {
            _maintenanceDescriptionDal.Update(maintenanceDescription);
            return new SuccessResult();
        }
    }
}
