using Business.Abstract;
using Business.Constants;
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
    public class CarModelManager : ICarModelService
    {
        ICarModelDal _carModelDal;

        public CarModelManager(ICarModelDal carModelDal)
        {
            _carModelDal = carModelDal;
        }

        public IResult Add(CarModel carModel)
        {
            _carModelDal.Add(carModel);
            return new SuccessResult();
        }

        public IResult Delete(CarModel carModel)
        {
            _carModelDal.Delete(carModel);
            return new SuccessResult();
        }

        public IDataResult<List<CarModel>> GetAll()
        {
            return new SuccessDataResult<List<CarModel>>(_carModelDal.GetAll());
        }

        public IDataResult<CarModel> GetById(int id)
        {
            return new SuccessDataResult<CarModel>(_carModelDal.Get(c => c.ModelId == id));
        }

        public IResult Update(CarModel carModel)
        {
            _carModelDal.Update(carModel);
            return new SuccessResult();
        }
    }
}
