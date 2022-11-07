using ASPDotNetMVCRepositoryApp.Manager;
using ASPDotNetMVCRepositoryApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDotNetMVCRepositoryApp.Controllers
{
    public class StudentController : Controller
    {
         StudentManager _studentManager=new StudentManager();
        //public StudentController(StudentManager studentManager)
        //{
        //    _studentManager = studentManager;
        //}
        // GET: Student
        public ActionResult Index()
        {
            var students = _studentManager.GetAll();
            return View(students);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student student)
        {
            bool Check = _studentManager.isExistRegNo(student.RegNo);
            if(Check)
            {
                ViewBag.Message = "RegNo already Exists";
                return View();
            }
            else
            {
                if (ModelState.IsValid)
                {
                    bool isChecked = _studentManager.Add(student);
                    if (isChecked)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        ViewBag.Msg = "Student not saved";
                    }
                }
            }
           
            return View(student);
        }

        public ActionResult Details(int id)
        {
            var student = _studentManager.GetById(id);
            return View(student);
        }

        public ActionResult Edit(int id)
        {
            var student = _studentManager.GetById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            if(ModelState.IsValid)
            {
                bool upRegCheck = _studentManager.isExistRegNo(student.RegNo);
                if(upRegCheck)
                {
                    bool isChecked = _studentManager.Update(student);
                    if (isChecked)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                else
                {
                    ViewBag.Message = "Registration Already Exists";
                    return View();
                }
            }
            return View(student);
        }

        public ActionResult Delete(int id)
        {
            var student = _studentManager.GetById(id);
            if(student == null)

            {
                return HttpNotFound();
            }
            return View(student);
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            bool isChecked = _studentManager.Delete(student);
            if(isChecked)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}