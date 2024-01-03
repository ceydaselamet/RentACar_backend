using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetails(Expression<Func<RentalDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from rental in context.Rentals

                             join car in context.Cars
                             on rental.CarId equals car.CarId

                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId

                             join user in context.Users
                             on customer.UserId equals user.UserId

                             join status in context.Statuses
                             on rental.StatusId equals status.StatusId

                             select new RentalDetailDto
                             {
                                 CarId = car.CarId,
                                 FullName = user.FirstName + " " + user.LastName,
                                 RentDate = Convert.ToDateTime(rental.RentDate),
                                 ReturnDate = Convert.ToDateTime(rental.ReturnDate),
                                 CarStatus = status.CarStatus
                             };
                return filter == null
              ? result.ToList()
              : result.Where(filter).ToList();
            }
        }
    }
}
