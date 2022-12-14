using Microsoft.AspNetCore.Mvc;
using APIDoanV.Models;

namespace APIDoanV.Controllers
{
    [ApiController]
    public class CategoryController : Controller
    {
        ApiContext db = new ApiContext();
        [Route("get_all_category")]
        [HttpGet]
        public IActionResult Getall()
        {
            var obj = db.LoaiSps.Select(x => new
            {
                Id = x.Id,
                Tenloai=x.Tenloai 
            });
            return Json(obj);
        }
        [Route("get_category_byid")]
        [HttpGet]
        public IActionResult Getbyid(string id)
        {
            var obj = db.LoaiSps.Select(x => new
            {
                Id = x.Id,
                Tenloai = x.Tenloai
            }).Where(x=>x.Id==id).FirstOrDefault();
            return Json(obj);
        }
        [Route("add_Category")]
        [HttpGet]
        public void addCategory(LoaiSp lsp)
        {
            try
            {
                lsp.Id = Guid.NewGuid().ToString();
                db.LoaiSps.Add(lsp);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        [Route("delete_Category")]
        [HttpDelete]
        public void deleteCategory(string malsp)
        {
            try
            {
                LoaiSp lsp = db.LoaiSps.Where(x => x.Id == malsp).FirstOrDefault();
                db.LoaiSps.Remove(lsp);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
