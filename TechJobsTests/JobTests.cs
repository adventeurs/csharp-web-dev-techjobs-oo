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

            Assert.IsFalse(job.Equals(job2));        }



    }
}

