using High.School.RecordKeepingApi.DomainModels.Base;
using High.School.RecordKeepingApi.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.RepositoryService
{
    public class StudentService
    {
        private readonly IMongoCollection<StudentResultsModel> _students;

        public StudentService(IPalmHighSchoolDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _students = database.GetCollection<StudentResultsModel>(settings.StudentResultCollectionName);
        }

        public List<StudentResultsModel> Get() => _students.Find(student => true)
                        .ToList();

        public StudentResultsModel Get(string id) =>
            _students.Find<StudentResultsModel>(student => student.Id == id).FirstOrDefault();

        public StudentResultsModel Create(StudentResultsModel student)
        {
            _students.InsertOne(student);
            return student;
        }

        public void Update(string id, StudentResultsModel studentIn) =>
            _students.ReplaceOne(student => student.Id == id, studentIn);

        public void Remove(StudentResultsModel studentIn) =>
            _students.DeleteOne(student => student.Id == studentIn.Id);

        public void Remove(string id) =>
            _students.DeleteOne(student => student.Id == id);
    }

}
