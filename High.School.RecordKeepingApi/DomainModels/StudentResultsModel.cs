using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.Models
{
    [BsonIgnoreExtraElements]
    public class StudentResultsModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string StudentName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Subject { get; set; }
        public int Year { get; set; }
        public int Result { get; set; }
        public string Status { get; set; }

    }
}
