using Core.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.DTOs
{
    public class DetailDTO
    {
        public List<CarDetailDto> data { get; set; }
        public bool success { get; set; }
        public object message { get; set; }

        
    }
}
