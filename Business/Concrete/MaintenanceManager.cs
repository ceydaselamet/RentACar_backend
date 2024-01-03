using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MaintenanceManager : IMaintenanceService
    {
        IMaintenanceDal _maintenanceDal;
        public MaintenanceManager(IMaintenanceDal maintenanceDal)
        {
            _maintenanceDal = maintenanceDal;
        }
        public IResult Add(Maintenance maintenance)
        {
            _maintenanceDal.Add(maintenance);
            return new SuccessResult();
        }

        public IResult Delete(Maintenance maintenances)
        {
            _maintenanceDal.Delete(maintenances);
            return new SuccessResult();
        }

        public IDataResult<List<Maintenance>> GetAll()
        {
            return new SuccessDataResult<List<Maintenance>>(_maintenanceDal.GetAll());
        }

        public IDataResult<List<Maintenance>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Maintenance>>(_maintenanceDal.GetAll(m => m.CarId == carId));
        }

        public IDataResult<Maintenance> GetById(int id)
        {
            return new SuccessDataResult<Maintenance>(_maintenanceDal.Get(m => m.MaintenanceId == id));
        }

        public IDataResult<List<MaintenanceDetailDto>> GetMeintenanceDetails()
        {
            return new SuccessDataResult<List<MaintenanceDetailDto>>(_maintenanceDal.GetMaintenanceDetails());
        }

        public IResult Update(Maintenance maintenance)
        {
            _maintenanceDal.Update(maintenance);
            return new SuccessResult();
        }
    }
}
