using High.School.RecordKeepingApi.RepositoryService;
using System;
using System.IO;

namespace High.School.RecordKeepingLoadData
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentService = new StudentService(new )

            foreach (string line in System.IO.File.ReadLines(@"SchoolResultsDBDataStruicture.csv"))
            {
                var splitRes = line.Split(";");
                foreach (string resLine in splitRes)
                {

                }
            }
        }

       
    }
}
