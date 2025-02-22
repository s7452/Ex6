﻿using Ex6.DTOs.Requests;
using Ex6.DTOs.Responses;
using Ex6.Models;
using Ex6.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Ex6.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {

        private IStudentDbService _service;

        public EnrollmentsController(IStudentDbService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult EnrollStudent(EnrollStudentRequest request)
        {
            _service.EnrollStudent(request);
            //var response = new EnrollStudentResponse();
            return Ok("Enrolled");
        }

        [HttpPost("promotions")]
        public IActionResult PromoteStudent(PromoteStudentRequest request)
        {
            _service.PromoteStudnet(request.semester, request.studies);
            //var response = new PromoteStudentResponse();
            return Ok("Promoted");
        }
    }
}
