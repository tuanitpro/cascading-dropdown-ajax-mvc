using CascadingDropdownApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CascadingDropdownApp.Controllers
{
    /// <summary>
    /// Class chứa các method lấy dữ liệu
    /// </summary>
    public class ServiceController : Controller
    {
        /// <summary>
        /// Hàm lấy danh sách Country
        /// Test OK
        /// </summary>
        /// <returns></returns>
        public JsonResult GetAllCountries()
        {
            using(var db = new MyDbContext())
            {
                var data = db.Countries.OrderBy(x=>x.Name).ToList();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// Hàm lấy danh sách tỉnh thành theo CountryId. 
        /// Id = 237 là của Việt Nam. Do database mình quy định vậy
        /// Test OK
        /// </summary>
        /// <param name="id">Id của country</param>
        /// <returns></returns>
        public JsonResult GetAllProvinceByCountryId(int? id=237) 
        {
            using (var db = new MyDbContext())
            {               
                var data = db.Provinces.Where(x=>x.CountryId== id).OrderBy(x=>x.Name).ToList();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// Hàm lấy tất cả danh sách quận huyện
        /// Id = 1 là Hà Nội, do database mình quy định vậy
        /// Test OK
        /// </summary>
        /// <param name="id">Id = ProvinceId</param>
        /// <returns></returns>
        public JsonResult GetAllDistrictByProvinceId(int? id = 1)
        {
            using (var db = new MyDbContext())
            {
                var data = db.Districts.Where(x => x.ProvinceId == id).OrderBy(x=>x.Name).ToList();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        /// <summary>
        /// Hàm lấy danh sách xã phường theo quận huyện
        /// Id= 1 là Ba Đình. Do database quy định
        /// Test OK
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult GetAllWardByDistrictId(int? id = 1)
        {
            using (var db = new MyDbContext())
            {
                var data = db.Wards.Where(x => x.DistrictId == id).OrderBy(x=>x.Name).ToList();
                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }
        // Xong nhiệm vụ phía server, bạn chỉ cần nhớ tên các phương thức đã tạo
        // Từ bây giờ không cần quan tâm nó nữa.
    }
}