﻿using Ex6.DAL;
using Ex6.Models;
using Ex6.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Ex6.Controllers
{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase
    {

        private readonly IStudentDbService _dbService;

        public StudentsController(IStudentDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var _students = _dbService.GetStudents();
            return Ok(_students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(string id)
        {
            var student = _dbService.GetStudent(id);
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Studnet zaktualizowany");
            }
            return NotFound("Nie znaleziono studenta"); ;
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            if (id == 2)
            {
                return Ok("Student został usunięty");
            }
            return NotFound("Nie znaleziono studenta");
        }
    }
}
