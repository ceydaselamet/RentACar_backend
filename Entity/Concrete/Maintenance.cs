using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Maintenance : IEntity
    {
        [Key]
        public int MaintenanceId { get; set; }
        public int CarId { get; set; }
        //public int CustomerId { get; set; }
        public int MaintenanceDescriptionId { get; set; }
        public DateTime Date { get; set; }
    }
}
