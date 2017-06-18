using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CascadingDropdownApp.Models
{
    [Table("District")]
    public class District:Entity
    {
        public int ProvinceId { get; set; }
    }
}