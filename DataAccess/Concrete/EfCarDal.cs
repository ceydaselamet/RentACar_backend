using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq.Expressions;

public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (RentACarContext context = new RentACarContext()) 
        {
            var result = from car in context.Cars

                         join brand in context.Brands
                         on car.BrandId equals brand.BrandId

                         join color in context.Colors
                         on car.ColorId equals color.ColorId

                         join model in context.CarModels
                         on car.ModelId equals model.ModelId

                         join fuelType in context.FuelTypes
                         on car.FuelTypeId equals fuelType.FuelTypeId

                         join gearType in context.GearTypes
                         on car.GearTypeId equals gearType.GearId

                         

                         select new CarDetailDto
                         {
                             CarId = car.CarId,
                             ColorName = color.ColorName,
                             BrandName = brand.BrandName,
                             ModelName = model.ModelName,
                             ModelYear = car.ModelYear,
                             DailyPrice = car.DailyPrice,
                             CarImage = car.CarImage,
                             FuelTypeName = fuelType.FuelTypeName,
                             GearTypeName = gearType.GearTypeName,
                             IsSuitable = car.IsSuitable
                         };
            return result.ToList();
        } 
    }

    public List<CarDetailDto> GetCarDetailsByCarId(Expression<Func<CarDetailDto, bool>> filter = null)
    {
        using (RentACarContext context = new RentACarContext())
        {
            var result = from car in context.Cars

                         join brand in context.Brands
                         on car.BrandId equals brand.BrandId

                         join color in context.Colors
                         on car.ColorId equals color.ColorId

                         join model in context.CarModels
                         on car.ModelId equals model.ModelId

                         join fuelType in context.FuelTypes
                         on car.FuelTypeId equals fuelType.FuelTypeId

                         join gearType in context.GearTypes
                         on car.GearTypeId equals gearType.GearId

                         select new CarDetailDto
                         {
                             CarId = car.CarId,
                             ColorName = color.ColorName,
                             BrandName = brand.BrandName,
                             ModelName = model.ModelName,
                             ModelYear = car.ModelYear,
                             DailyPrice = car.DailyPrice,
                             CarImage = car.CarImage,
                             FuelTypeName = fuelType.FuelTypeName,
                             GearTypeName = gearType.GearTypeName,
                             IsSuitable = car.IsSuitable
                         };
            return filter == null
                ? result.ToList()
                : result.Where(filter).ToList();
        }
    }
}
