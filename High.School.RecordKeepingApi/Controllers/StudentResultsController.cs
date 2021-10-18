using High.School.RecordKeepingApi.Models;
using High.School.RecordKeepingApi.RepositoryService;
using High.School.RecordKeepingApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentResultsController : ControllerBase
    {
        private readonly ILogger<StudentResultsController> _logger;
        private readonly StudentService _studentResultsService;

        public StudentResultsController(ILogger<StudentResultsController> logger,
                                        StudentService studentResultsService)
        {
            _logger = logger;
            _studentResultsService = studentResultsService;
        }

        [HttpGet]
        public IEnumerable<StudentResultsModel> Get()
        {
            return _studentResultsService.Get()
                                         .DistinctBy(t => new { t.StudentName, t.Subject, t.Result });
        }

        [HttpGet("{id:length(24)}", Name = "GetStudentResult")]
        public ActionResult<StudentResultsModel> Get(string id)
        {
            var student = _studentResultsService.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpPost]
        public ActionResult<StudentResultsModel> Create(StudentResultsModel student)
        {
            _studentResultsService.Create(student);

            return CreatedAtRoute("GetStudentResult", new { id = student.Id.ToString() }, student);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, StudentResultsModel studentIn)
        {
            var student = _studentResultsService.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            _studentResultsService.Update(id, studentIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var student = _studentResultsService.Get(id);

            if (student == null)
            {
                return NotFound();
            }

            _studentResultsService.Remove(student.Id);

            return NoContent();
        }

        [HttpPost("BulkCreate", Name = "BulkCreate")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> BulkCreate(
                                             IFormFile file,
                                             CancellationToken cancellationToken)
        {
            if (CheckIfCsvFile(file))
            {
                var studentResultsFeed = await ReadFormFileAsync(file);
                foreach (var studentRes in studentResultsFeed)
                {
                    _studentResultsService.Create(studentRes);
                }
            }
            else
            {
                return BadRequest(new { message = "Invalid file extension" });
            }

            return Ok();
        }

        private bool CheckIfCsvFile(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".csv" || extension == ".txt"); // Change the extension based on your need
        }

        private async Task<List<StudentResultsModel>> ReadFormFileAsync(IFormFile file)
        {
            var stdResModList = new List<StudentResultsModel>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    var line = await reader.ReadLineAsync();
                    var splitVal = line.Split(";");
                    stdResModList.Add(new StudentResultsModel()
                    {
                        StudentName = splitVal[0],
                        DateOfBirth = DateTime.Parse(splitVal[1]),
                        Subject = splitVal[2],
                        Year = Convert.ToInt32(splitVal[3]),
                        Result = Convert.ToInt32(splitVal[4]),
                        Status = splitVal[5],

                    });

                }


            }

            return stdResModList;
        }


    }
}
