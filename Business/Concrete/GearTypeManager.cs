﻿using Business.Abstract;
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
    public class GearTypeManager : IGearTypeService
    {
        IGearTypeDal _gearTypeDal;

        public GearTypeManager(IGearTypeDal gearTypeDal)
        {
            _gearTypeDal = gearTypeDal;
        }

        public IResult Add(GearType gearType)
        {
            _gearTypeDal.Add(gearType);
            return new SuccessResult();
        }

        public IResult Delete(GearType gearType)
        {
            _gearTypeDal.Delete(gearType);
            return new SuccessResult();
        }

        public IDataResult<List<GearType>> GetAll()
        {
            return new SuccessDataResult<List<GearType>>(_gearTypeDal.GetAll());
        }

        public IDataResult<GearType> GetById(int id)
        {
            return new SuccessDataResult<GearType>(_gearTypeDal.Get(g => g.GearId == id));
        }

        public IResult Update(GearType GearType)
        {
            _gearTypeDal.Update(GearType);
            return new SuccessResult();
        }
    }
}
