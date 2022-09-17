using Assignment.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdhaar adhaar;
        private readonly IWebHostEnvironment hostingEnvironment;

        public HomeController(ILogger<HomeController> logger,IAdhaar _adhaar, IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            adhaar = _adhaar;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            var model = adhaar.GetEmployeeList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(TblAdhaarDetail model)
        {
            if (ModelState.IsValid)
            {
                string uniquefilename = ProceessUploadedFile(model);
                TblAdhaarDetail newObject = new TblAdhaarDetail
                {
                    Name = model.Name,
                    Email = model.Email,
                    Dob = model.Dob,
                    Pincode=model.Pincode,
                    City=model.City,
                    AdhaarNumber=model.AdhaarNumber,
                    Gender=model.Gender,
                    State=model.State,
                    MobileNo=model.MobileNo,
                    AdhaarFrontImage = uniquefilename
                };
                adhaar.Add(newObject);
            }
            return RedirectToAction("index");

        }
        private string ProceessUploadedFile(TblAdhaarDetail model)
        {
            string uniquefilename = null;
            if (model.PhotoFront != null)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath + "\\images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.PhotoFront.FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    model.PhotoFront.CopyTo(filestream);

                }
            }

            return uniquefilename;
        }
        private string ProceessUploadedFile1(TblAdhaarDetail model)
        {
            string uniquefilename = null;
            if (model.PhotoBack != null)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath + "\\images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.PhotoBack.FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    model.PhotoBack.CopyTo(filestream);

                }
            }

            return uniquefilename;
        }
        private string ProceessUploadedFil2(TblAdhaarDetail model)
        {
            string uniquefilename = null;
            if (model.PanDoc != null)
            {
                string UploadsFolder = Path.Combine(hostingEnvironment.WebRootPath + "\\images");
                uniquefilename = Guid.NewGuid().ToString() + "_" + model.PanDoc.FileName;
                string filepath = Path.Combine(UploadsFolder, uniquefilename);
                using (var filestream = new FileStream(filepath, FileMode.Create))
                {
                    model.PanDoc.CopyTo(filestream);

                }
            }

            return uniquefilename;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
