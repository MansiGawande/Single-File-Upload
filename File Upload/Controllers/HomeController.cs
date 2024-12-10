using File_Upload.Data;
using File_Upload.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace File_Upload.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment) {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upload (IFormFile? file, Gift gift) {
            string wwwRootPath = _webHostEnvironment.WebRootPath;

            if(file != null)  {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName); // it gives random no. with its extension
                string GiftPath = Path.Combine(wwwRootPath, @"images\gift");

                string giftImage = gift.GiftImage;

                // url is exist  && select new file delete prev file
//                if (!string.IsNullOrEmpty(giftImage))
//                {
//                    var oldImgPath = Path.Combine(wwwRootPath, giftImage.TrimStart('\\'));

//                    if (System.IO.File.Exists(oldImgPath))
//{
//                        System.IO.File.Delete(oldImgPath);
//                    }
//                }
                using (var fileStream = new FileStream(Path.Combine(GiftPath, fileName), FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }

                gift.GiftImage = @"\images\gift\" + fileName;
           
               
                _db.Gifts.Add(gift);
                _db.SaveChanges();
            }
            TempData["success"] = "Gift Image Uploaded successfully";
            return RedirectToAction("Index"); // after add go view all Gifts

          
        }

   
    }
}
