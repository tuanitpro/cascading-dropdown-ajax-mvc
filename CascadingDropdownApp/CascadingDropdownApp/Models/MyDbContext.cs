using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CascadingDropdownApp.Models
{
    /// <summary>
    /// Class kế thừa DbContext, thực hiện truy vấn dữ liệu
    /// Các bạn nhớ Add EntityFramework
    /// </summary>
    public class MyDbContext:DbContext
    {
        // Ở đây các bạn có thể khai báo trong Web.config.
        private const string sqlConnection = @"Data Source=.\SQLExpress; Initial Catalog = CountryDb; User Id=sa; Password = sa";

        public MyDbContext() : base(sqlConnection)
        {

        }
        //public MyDbContext() : base("TenKhaiBaoTrongWebConfig")
        //{
        // Nếu tên khai báo = MyDbContext => thì không cần base
        //}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Ward> Wards { get; set; }

        // OK. Xong bước đăng ký với EF.
    }
}