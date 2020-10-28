using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job = new Job();
            Job job2 = new Job();
            Assert.AreNotEqual(job.Id, job2.Id);
            Assert.AreEqual(job.Id + 1, job2.Id);
        }


        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product tester", employer, location, jobType, jobCoreCompetency);
            Assert.AreEqual(job.Name, "Product tester");
            Assert.AreEqual(job.EmployerName, employer);
            Assert.AreEqual(job.EmployerLocation, location);
            Assert.AreEqual(job.JobType, jobType);
            Assert.AreEqual(job.JobCoreCompetency, jobCoreCompetency);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product tester", employer, location, jobType, jobCoreCompetency);
            Job job2 = new Job("Product tester", employer, location, jobType, jobCoreCompetency);

            Assert.IsFalse(job.Equals(job2));
        }
        [TestMethod]
        public void TestJobsToString()
        {
            Employer employer = new Employer("ACME");
            Location location = new Location("Desert");
            PositionType jobType = new PositionType("Quality control");
            CoreCompetency jobCoreCompetency = new CoreCompetency("Persistence");
            Job job = new Job("Product tester", employer, location, jobType, jobCoreCompetency);

            Assert.AreEqual(job.ToString(), @"ID: 6
Name: Product tester
Employer: ACME
Location: Desert
Position Type: Quality control
Core Competency: Persistence");
        }
        [TestMethod]
        public void TestJobsToStringHasEmpty()
        {
            Employer employer = new Employer("");
            Location location = new Location("");
            PositionType jobType = new PositionType("");
            CoreCompetency jobCoreCompetency = new CoreCompetency("");
            Job job = new Job("", employer, location, jobType, jobCoreCompetency);

            Assert.AreEqual(job.ToString(), @"ID: 7
Name: Data not available
Employer: Data not available
Location: Data not available
Position Type: Data not available
Core Competency: Data not available");
        }
        [TestMethod]
        public void TestJobsToStringAllEmpty()
        {
            Job job = new Job();

            Assert.AreEqual(job.ToString(), @"OOPS! This job does not seem to exist.");
        }


    }

}


