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
    public class TeacherController : Controller
    {
        [HttpGet]
        public IEnumerable<TeacherViewModel> Get()
        {
            return new DataMock().teacherVMList;
        }
    }
}
