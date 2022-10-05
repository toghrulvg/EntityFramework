using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SliderSummary: BaseEntity
    {
        public string ImageTitle { get; set; }
        public string ImageDescription { get; set; }
        public string SliderLogo { get; set; }
    }
}
