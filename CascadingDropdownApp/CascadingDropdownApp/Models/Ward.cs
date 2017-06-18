using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CascadingDropdownApp.Models
{
    [Table("Ward")]
    public class Ward:Entity
    {
        public int DistrictId { get; set; }
    }
}