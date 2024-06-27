using ExamWeb_NguyenPhiVuong.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ExamWeb_NguyenPhiVuong.Controllers
{
    public class MusicController : Controller
    {

        private readonly ApplicationDbContext _db;
        public MusicController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Hiển thị danh sách chủng loại
        public IActionResult Index()
        {
            var listMusic = _db.DiaNhacs.ToList();
            return View(listMusic);
        }
        //Hiển thị form thêm mới chủng loại
        public IActionResult Add()
        {
            return View();
        }
        // Xử lý thêm chủng loại mới
        [HttpPost]
        public IActionResult Add(DiaNhac dianhac)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //thêm category vào table Categories
                _db.DiaNhacs.Add(dianhac);
                _db.SaveChanges();
                
            
                TempData["success"] = "Category inserted success";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form cập nhật chủng loại
        public IActionResult Update(int id)
        {
            var dianhac = _db.DiaNhacs.Find(id);
            if (dianhac == null)
            {
                return NotFound();
            }
            return View(dianhac);
        }
        // Xử lý cập nhật chủng loại
        [HttpPost]
        public IActionResult Update(DiaNhac dianhac)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //cập nhật category vào table Categories
                _db.DiaNhacs.Update(dianhac);
                _db.SaveChanges();
                TempData["success"] = "Category updated success";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form xác nhận xóa chủng loại
        public IActionResult Delete(int id)
        {
            var dianhac = _db.DiaNhacs.FirstOrDefault(x => x.Id == id);
            if (dianhac == null)
            {
                return NotFound();
            }
            return View(dianhac);
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var dianhac = _db.DiaNhacs.Find(id);
            if (dianhac == null)
            {
                return NotFound();
            }
            _db.DiaNhacs.Remove(dianhac);
            _db.SaveChanges();
            TempData["success"] = "Category deleted success";
            return RedirectToAction("Index");
        }
    }
}
