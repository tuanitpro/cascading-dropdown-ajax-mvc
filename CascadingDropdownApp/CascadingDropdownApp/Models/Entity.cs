using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownApp.Models
{
    /// <summary>
    /// Đây là class dùng chung
    /// Các thuộc tính tương ứng với Field của CSDL
    /// </summary>
    public class Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SortOrder { get; set; } 
    }
}