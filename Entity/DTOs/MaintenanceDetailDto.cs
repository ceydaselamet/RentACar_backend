using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class MaintenanceDetailDto : IDto
    {
        public int MaintenanceId { get; set; }
        public int CarId { get; set; }
        //public string CarName { get; set; }
        public string MaintenanceType { get; set; }
        public DateTime Date { get; set; }
    }
}
