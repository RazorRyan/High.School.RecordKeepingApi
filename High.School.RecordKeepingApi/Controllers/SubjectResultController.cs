using High.School.RecordKeepingApi.Data;
using High.School.RecordKeepingApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectResultController : Controller
    {
        [HttpGet]
        public IEnumerable<SubjectResultViewModel> Get()
        {
            var dataMock = new DataMock();

            var student = dataMock.studentVMList.First();

            var subject = dataMock.subjectVMList.First();

            var teacher = dataMock.teacherVMList.First();

            return new List<SubjectResultViewModel>()
            {
                new SubjectResultViewModel()
                {
                    StudentName = student.FirstName + " " + student.LastName,
                    SubjectName = subject.Name,
                    TeacherName = teacher.FirstName + " " + teacher.LastName,
                    Result = "90"
                }
            };
        }
    }
}
