﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration.UserSecrets;
using Newtonsoft.Json.Linq;
using System.Configuration;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class DangkyATTP : Controller
    {
        private readonly IWebHostEnvironment _webHost;
        private DataContext _dataContext;

        public DangkyATTP(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
            _dataContext = new DataContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //Chạy cái action Insert của form ở view Index
        public ActionResult Insert(string tencoso, string diachi, int? loaihinhkinhdoanh, string sogiayphep, DateOnly ngaycap, string loaithucpham, List<IFormFile> hinhanh)
        {
            String imageNames = "";
            String loaihinhkd;
            foreach(IFormFile file in hinhanh)
            {
                imageNames = file.FileName+ ",";
            }
            if (loaihinhkinhdoanh == 1)
                loaihinhkd = "Cơ sở sản xuất, kinh doanh thực phẩm";
            else
                loaihinhkd = "Cơ sở kinh doanh dịch vụ ăn uống";
            // chay lenh insert
            int maHoSo = _dataContext.insertGiayChungNhan_CoSo(tencoso, diachi, loaihinhkd, sogiayphep, ngaycap, loaithucpham, imageNames);

            //luu file
            string uploadFolder = Path.Combine(_webHost.WebRootPath, "HoSoDangKyATTP", maHoSo.ToString());
            if (!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
            foreach(IFormFile file in hinhanh)
            {
                SaveImage(file, uploadFolder);
            }
            return View("Index");
        }

        //Function lưu hình ảnh
        public async void SaveImage(IFormFile file, string path)
        {
            string fileName = Path.GetFileName(file.FileName);
            string fileSavePath = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(fileSavePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }

        public async Task<ActionResult> Test(List<IFormFile> file)
        {
            string uploadFile = Path.Combine(_webHost.WebRootPath,"HoSoDangKyATTP","1"); //1 la ma cua ho so
            if(!Directory.Exists(uploadFile))
            {
                Directory.CreateDirectory(uploadFile);
            }
            foreach(IFormFile f in file)
            {
                SaveImage(f,uploadFile);
            }
            ViewBag.message = "upload successfully";
            return View();
        }

        


		



	}
}
