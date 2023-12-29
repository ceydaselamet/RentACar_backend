using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class FuelType : IEntity
    {
        [Key]
        public int FuelTypeId { get; set; }
        public string FuelTypeName { get; set; }
    }
}
