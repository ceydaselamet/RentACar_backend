using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Color = Entities.Concrete.Color;

namespace WinFormsApp2.ApiResponse.EntityConcrete
{
    public class ColorApiResponse : IApiResponse<Color>
    {
        public List<Color> Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }

}
