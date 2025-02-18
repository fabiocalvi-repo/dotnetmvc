using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MvcExample.Models;

namespace MvcExample.Controllers;

public class StudentsController : Controller{

    private static List<Student> students = new List<Student>{
        new Student {Id=1, Name="Alberto", Address="Treviglio"},
        new Student {Id=2, Name="Sabrina", Address="Milano"},
        new Student {Id=3, Name="Fabio", Address="Vimercate"}
    };

    public IActionResult Index()
    {
        return View(students);
    }
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        student.Id=students.Count+1;
        students.Add(student);
        return RedirectToAction("Index");
    }

}
