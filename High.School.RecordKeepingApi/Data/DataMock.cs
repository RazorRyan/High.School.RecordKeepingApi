using High.School.RecordKeepingApi.Models;
using High.School.RecordKeepingApi.ViewModels;
using System.Collections.Generic;

namespace High.School.RecordKeepingApi.Data
{
    public class DataMock
    {
        public List<StudentModel> studentVMList => new List<StudentModel>()
        {
            new StudentModel()
            {
                FirstName = "Ryan",
                LastName = "Blah",
                DOB = "1988/05/25",
                Year = "2000",
            },
            new StudentModel()
            {
                FirstName = "Tesrt",
                LastName = "dsfdds",
                DOB = "2005/05/25",
                Year = "2011",
            },
            new StudentModel()
            {
                FirstName = "hey",
                LastName = "ho",
                DOB = "2015/05/25",
                Year = "2010",
            }
        };


        public List<SubjectModel> subjectVMList => new List<SubjectModel>()
        {
            new SubjectModel()
            {
                Name="Economics",
                Code="ECO001",
                Level="1"
            },
            new SubjectModel()
            {
                Name="Science",
                Code="SCC001",
                Level="1"
            },
            new SubjectModel()
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


        public List<SubjectResultModel> subjectResultVMList => new List<SubjectResultModel>()
        {
            new SubjectResultModel()
            {
                StudentName = "Hello I wanna know",
                SubjectName = "ECONOMICS",
                TeacherName = "Nobody cares",
                Result = "50"
            },
        };
    }
}
