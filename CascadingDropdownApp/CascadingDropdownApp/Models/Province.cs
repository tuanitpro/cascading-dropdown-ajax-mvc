using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CascadingDropdownApp.Models
{
    [Table("Province")] // Tên table của bạn
    public class Province:Entity
    {
        public int CountryId { get; set; }
    }
}