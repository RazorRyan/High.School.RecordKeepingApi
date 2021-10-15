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
    public class SubjectController : Controller
    {
        [HttpGet]
        public IEnumerable<SubjectViewModel> Get()
        {
            return new DataMock().subjectVMList;
        }
    }
}
