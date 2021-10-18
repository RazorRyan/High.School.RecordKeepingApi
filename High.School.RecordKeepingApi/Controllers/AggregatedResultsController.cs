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
    public class AggregatedResultsController : ControllerBase
    {
        private readonly ILogger<AggregatedResultsController> _logger;
        private readonly StudentService _studentResultsService;

        public AggregatedResultsController(ILogger<AggregatedResultsController> logger,
                                        StudentService studentResultsService)
        {
            _logger = logger;
            _studentResultsService = studentResultsService;
        }

        [HttpGet]
        [Route("GetByStudentAverage")]
        public IEnumerable<AverageResultVM> GetByStudentAverage()
        {
            return _studentResultsService.Get()
                                       .GroupBy(t => new { t.StudentName, t.Result })
                                       .Select(g => new AverageResultVM()
                                       {
                                           Key = g.Key.StudentName,
                                           Value = (int)g.Average(p => p.Result),
                                       }).ToList();
        }


        [HttpGet]
        [Route("GetBySubjectAverage")]
        public IEnumerable<AverageResultVM> GetBySubjectAverage()
        {
            return _studentResultsService.Get()
                                       .GroupBy(t => new { t.Subject, t.Result })
                                       .Select(g => new AverageResultVM()
                                       {
                                           Key = g.Key.Subject,
                                           Value = (int)g.Average(p => p.Result),
                                       }).ToList();
        }

    }
}
