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
    public class EfMaintenanceDal : EfEntityRepositoryBase<Maintenance, RentACarContext>, IMaintenanceDal
    {
        public List<MaintenanceDetailDto> GetMaintenanceDetails(Expression<Func<MaintenanceDetailDto, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from maintenance in context.Maintenances

                             join maintenanceDescription in context.MaintenanceDescriptions
                             on maintenance.MaintenanceDescriptionId equals maintenanceDescription.MaintenanceDescriptionId

                             join car in context.Cars
                             on maintenance.CarId equals car.CarId

                             select new MaintenanceDetailDto
                             {
                                 MaintenanceId = maintenance.MaintenanceId,
                                 CarId = car.CarId,
                                 MaintenanceType = maintenanceDescription.MaintenanceType,
                                 Date = maintenance.Date
                             };

                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
