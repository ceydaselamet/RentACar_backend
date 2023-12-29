﻿using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string ModelName { get; set; }   
        public string FuelTypeName { get; set; }
        public string GearTypeName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarImage { get; set; }

        [DefaultValue(false)]
        public bool IsSuitable { get; set; }

    }
}
