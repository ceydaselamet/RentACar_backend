using Core.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class GearType : IEntity
    {
        [Key]
        public int GearId { get; set; }
        public string GearTypeName { get; set; }
    }
}
