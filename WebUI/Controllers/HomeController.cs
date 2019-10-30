using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService _studentService;
        public HomeController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var student = _studentService.GetAll();
            return View(student);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var student = new Student();
            return View(student);
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Add(student);
            }
            return RedirectToAction("Index");

        }

        public IActionResult Details(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }


        [HttpPost]
        public IActionResult Update(Student student)
        {
            _studentService.Update(student);
            return View();
        }
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = _studentService.GetStudentById(id);
            _studentService.Delete(student);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetStudentById(id);
            return View(student);
        }

        public IActionResult Edit(Student student)
        {
            _studentService.Update(student);
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
