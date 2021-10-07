using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SRM_MVC.Services;
using SRM_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SRM_MVC.Controllers
{
    public class ResultController : Controller
    {
        private readonly IResultService _service = null;
        private readonly ISemesterService _semservice = null;
        private readonly IBranchService _branchService = null;
        private readonly IStudentService _studentService = null;
        private readonly ISubjectService _subjectService = null;
         //SemesterService semservices = new SemesterService();
        
        public ResultController(IResultService service,ISemesterService ssemester, IBranchService bservice, IStudentService sservice,ISubjectService subservice)
        {
            _service = service;
            _semservice = ssemester;
            _branchService = bservice;
            _studentService = sservice;
            _subjectService = subservice;
        }
        [HttpGet]
        public IActionResult AddResult()
        {
            //Name and Id can alter
            List<SelectListItem> studentList = _studentService.GetStudents().Select(n => new SelectListItem { Value = n.StudentId.ToString(), Text = n.FirstName }).ToList(); ;
            var stdTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Student ---"
            };
           
            List<SelectListItem> semlist = _semservice.GetSemesters().Select(n => new SelectListItem { Value = n.SemesterId.ToString(), Text = n.semester }).ToList(); ;
            var semTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Semester ---"
            };
            List<SelectListItem> SubjectList = _subjectService.GetSubjects().Select(n => new SelectListItem { Value = n.SubjectId.ToString(), Text = n.SubjectName }).ToList(); ;
            var subTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Subject ---"
            };

            studentList.Insert(0, stdTip);
            semlist.Insert(0, semTip);
            SubjectList.Insert(0, subTip);
            ViewBag.studentList = new SelectList(studentList, "Value", "text");
            ViewBag.SubjectList = new SelectList(SubjectList, "Value", "text");
            ViewBag.semslist = new SelectList(semlist, "Value","text");

            return View();

        }

        [HttpPost]
        public IActionResult AddResult(Result result)
        {
            List<SelectListItem> studentList = _studentService.GetStudents().Select(n => new SelectListItem { Value = n.StudentId.ToString(), Text = n.FirstName }).ToList(); ;
            var stdTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Student ---"
            };
            List<SelectListItem> SubjectList = _studentService.GetStudents().Select(n => new SelectListItem { Value = n.StudentId.ToString(), Text = n.FirstName }).ToList(); ;
            var subTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Subject ---"
            };
            List<SelectListItem> semlist = _semservice.GetSemesters().Select(n => new SelectListItem { Value = n.SemesterId.ToString(), Text = n.semester }).ToList(); ;
            var semTip = new SelectListItem()
            {
                Value = null,
                Text = "--- select Semester ---"
            };


            studentList.Insert(0, stdTip);
            SubjectList.Insert(0, subTip);
            semlist.Insert(0, semTip);
            ViewBag.studentList = new SelectList(studentList, "Value", "text");
            ViewBag.SubjectList = new SelectList(SubjectList, "Value", "text");
            ViewBag.semslist = new SelectList(semlist, "Value", "text");

            return RedirectToAction("GetResults");
            //return View();

        }
        [HttpGet]
        public IActionResult GetResults()
        {

            return View(_service.GetResults());
        }

        [HttpGet]

        public IActionResult Get(int id)
        {
            try
            {
                var result = _service.GetResult(id);
                if (result != null)
                    return Ok(result);
                else
                    return Content("Invalid Id");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Result result = _service.GetResult(id);
            return View(result);
        }
        [HttpPost]

        public IActionResult Edit(Result reslut)
        {
            _service.UpdateResult(reslut);

            return RedirectToAction("GetResults");
        }
        [HttpGet]

        public IActionResult Delete(int id)
        {
            Result reult = _service.GetResult(id);

            return View(reult);
        }

        [HttpPost]
        public IActionResult Delete(Result result)
        {
            _service.DeleteResult(result.ResultId);

            return RedirectToAction("GetResults");
        }
    }
}
