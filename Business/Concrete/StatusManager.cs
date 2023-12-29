using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StatusManager : IStatusService
    {
        IStatusDal _statusDal;
        public StatusManager(IStatusDal statusDal)
        {
            _statusDal = statusDal;
        }

        public IResult Add(Status Status)
        {
            _statusDal.Add(Status);
            return new SuccessResult();
        }

        public IResult Delete(Status Status)
        {
            _statusDal.Delete(Status);
            return new SuccessResult();
        }

        public IDataResult<List<Status>> GetAll()
        {
            return new SuccessDataResult<List<Status>>(_statusDal.GetAll());
        }

        public IDataResult<Status> GetById(int id)
        {
            return new SuccessDataResult<Status>(_statusDal.Get(b => b.StatusId == id));
        }

        public IResult Update(Status Status)
        {
            _statusDal.Update(Status);
            return new SuccessResult();
        }
    }
}
