using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using APIDoanV.Models;

namespace APIDoanV.Controllers
{    
    [ApiController]
    
    public class SanPhamController : Controller
    {
        ApiContext db = new ApiContext();
        [Route("getall")]
        [HttpGet]
        public ActionResult Get_all_Product()
        {
            var obj = db.SanPhams.Select(sp => new
            {
                id = sp.Id,
                name = sp.Name,
                id_loai_sp = sp.IdLoaiSp,
                unit_price = sp.UnitPrice,
                so_luong = sp.SoLuong,
                image = sp.Image,

            }).Take(8).ToList();
            return Json(obj);
        }
        [Route("get_by_id")]
        [HttpGet]
        public ActionResult Getid(string id)
        {
            var obj = db.SanPhams.Select(sp => new
            {
                id = sp.Id,
                name = sp.Name,
                id_loai_sp = sp.IdLoaiSp,
                unit_price = sp.UnitPrice,
                so_luong = sp.SoLuong,
                image = sp.Image,

            }).Where(x=>x.id==id).FirstOrDefault();
            return Json(obj);
        }
        [Route("get_list_product")]
        [HttpGet]
        public ActionResult Get_list_Product()
        {
            var obj = db.SanPhams.Select(sp => new
            {
                id = sp.Id,
                name = sp.Name,
                id_loai_sp = sp.IdLoaiSp,
                unit_price = sp.UnitPrice,
                so_luong = sp.SoLuong,
                image = sp.Image,

            }).ToList();
            return Json(obj);
        }
        [Route("add_Sp")]
        [HttpPost]
        public void addSP(SanPham sp)
        {
            sp.Id = Guid.NewGuid().ToString();
            try
            {
                db.SanPhams.Add(sp);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        [Route("Delete_Sp")]
        [HttpDelete]
        public void DeleteSP(string id)
        {
            try
            {
                SanPham sp = db.SanPhams.FirstOrDefault(sp => sp.Id == id);
                db.SanPhams.Remove(sp);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        [Route("Search")]
        [HttpGet]
        public IActionResult Search(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    var obj = db.SanPhams.Select(sp => new
                    {
                        id = sp.Id,
                        name = sp.Name,
                        id_loai_sp = sp.IdLoaiSp,
                        unit_price = sp.UnitPrice,
                        so_luong = sp.SoLuong,
                        image = sp.Image,

                    }).ToList();
                    return Json(obj);
                }
                else
                {
                    var obj = db.SanPhams.Select(sp => new
                    {
                        id = sp.Id,
                        name = sp.Name,
                        id_loai_sp = sp.IdLoaiSp,
                        unit_price = sp.UnitPrice,
                        so_luong = sp.SoLuong,
                        image = sp.Image,

                    }).Where(x => x.name.Contains(name)).ToList();
                    return Json(obj);

                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}
