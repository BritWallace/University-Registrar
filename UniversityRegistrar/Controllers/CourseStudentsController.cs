using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UniversityRegistrar.Controllers
{
  public class CourseStudentsController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public CourseStudentsController(UniversityRegistrarContext db)
    {
      _db = db;
    }

     public ActionResult Edit(int id)
    {
      var thisStudent = _db.CourseStudent.FirstOrDefault(courseStudent => courseStudent.CourseStudentId== id);
  
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(CourseStudent courseStudent)
    {
      if (courseStudent.CourseId == 0)
      {
        _db.CourseStudent.Add(new CourseStudent() { CourseStudentId = courseStudent.CourseStudentId});
      }
      _db.Entry(courseStudent).State = EntityState.Modified;
      Console.WriteLine(courseStudent.CourseId);
      _db.SaveChanges();
      return RedirectToAction("Edit");
    }
  }
}