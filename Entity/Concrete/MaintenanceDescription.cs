using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MaintenanceDescription : IEntity
    {
        [Key]
        public int MaintenanceDescriptionId { get; set; }
        public string MaintenanceType { get; set; }
    }
}
