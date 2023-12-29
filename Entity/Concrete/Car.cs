using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key]
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelId { get; set; }
        public int FuelTypeId { get; set; }
        public int GearTypeId { get; set; }
        public string? CarImage { get; set; }
        public bool  IsSuitable { get; set; }
    }
}
