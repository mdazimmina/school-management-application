using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.API.Data;
using SchoolManagement.API.Models;
using System.Net;
using SchoolManagement.API.Services;
using Microsoft.AspNetCore.Cors;

namespace SchoolManagement.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: api/Students
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var student = _studentService.GetStudents();
                return Ok(student);
            }
            catch (Exception e)
            {
                return BadRequest("An error occurred while creating the request");
            }
        }
        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            try
            {
                var student = _studentService.GetStudent(id);
                return Ok(student);
            }
            catch (Exception e)
            {

                return BadRequest("An error occurred while creating the resource");
            }
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                
                bool isSaved = _studentService.AddStudent(student);
                if (isSaved)
                {
                    return Ok(student);
                }
                return BadRequest("Something went wrong!");
            }
            catch (Exception e)
            {
                return BadRequest("An error occurred while creating the resource");
               
            }
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            try
            {

                if (!ModelState.IsValid || id != student.Id)
                {
                    return BadRequest();
                }
                bool isSaved = _studentService.UpdateStudent(student);
                if (isSaved)
                {
                    return Ok(student);
                }
                return BadRequest(student);
            }
            catch (Exception e)
            {
                return BadRequest("An error occurred while updating the resource");
            }

        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public  IActionResult DeleteStudent(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }
                bool isDeleted = _studentService.DeleteStudent(id);
                if (isDeleted)
                {
                    return Ok();
                }
                return BadRequest();
            }
            catch (Exception e)
            {
                return BadRequest("An error occurred while deleting the resource");
            }
        }
    }
}
