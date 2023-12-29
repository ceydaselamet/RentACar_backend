﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMaintenanceService
    {
        IDataResult<List<Maintenance>> GetAll();
        IDataResult<Maintenance> GetById(int id);
        IDataResult<List<Maintenance>> GetByCarId(int carId);

        IResult Add(Maintenance maintenance);
        IResult Update(Maintenance maintenance);
        IResult Delete(Maintenance maintenances);
    }
}
