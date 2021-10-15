using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace High.School.RecordKeepingApi.DomainModels.Base
{
    public class PalmHighSchoolDatabaseSettings : IPalmHighSchoolDatabaseSettings
    {
        public string StudentResultCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPalmHighSchoolDatabaseSettings
    {
        string StudentResultCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
