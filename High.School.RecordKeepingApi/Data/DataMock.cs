using High.School.RecordKeepingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.Data
{
    public class DataMock
    {
        public List<StudentViewModel> studentVMList => new List<StudentViewModel>()
        {
            new StudentViewModel()
            {
                FirstName = "Ryan",
                LastName = "Blah",
                DOB = "1988/05/25",
                Year = "2000",
            },
            new StudentViewModel()
            {
                FirstName = "Tesrt",
                LastName = "dsfdds",
                DOB = "2005/05/25",
                Year = "2011",
            },
            new StudentViewModel()
            {
                FirstName = "hey",
                LastName = "ho",
                DOB = "2015/05/25",
                Year = "2010",
            }
        };


        public List<SubjectViewModel> subjectVMList => new List<SubjectViewModel>()
        {
            new SubjectViewModel()
            {
                Name="Economics",
                Code="ECO001",
                Level="1"
            },
            new SubjectViewModel()
            {
                Name="Science",
                Code="SCC001",
                Level="1"
            },
            new SubjectViewModel()
            {
                Name="Economics",
                Code="ECO002",
                Level="2"
            }
        };

        public List<TeacherViewModel> teacherVMList => new List<TeacherViewModel>()
        {
            new TeacherViewModel()
            {
                FirstName = "Zane",
                LastName = "JOE",
                Title = "MR",
            },
            new TeacherViewModel()
            {
                FirstName = "Deborah",
                LastName = "Piet",
                Title = "Ms",
            },
            new TeacherViewModel()
            {
                FirstName = "Yoda",
                LastName = "Skywalker",
                Title = "DR",
            }
        };


        public List<SubjectResultViewModel> subjectResultVMList => new List<SubjectResultViewModel>()
        {
            new SubjectResultViewModel()
            {
                StudentName = "Hello I wanna know",
                SubjectName = "ECONOMICS",
                TeacherName = "Nobody cares",
                Result = "50"
            },
        };
    }
}
