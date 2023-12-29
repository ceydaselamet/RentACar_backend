﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.ApiResponse.EntityConcrete
{
    public class FuelTypeApiResponse : IApiResponse<FuelType>
    {
        public List<FuelType> Data { get; set; }
        public bool Success { get; set ; }
        public string Message { get; set ; }
    }
}
