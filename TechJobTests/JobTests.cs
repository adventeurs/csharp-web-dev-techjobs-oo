using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
//         We can initialize test variable here so we don't have to create them per test.
        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }
// 
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJobOne = new Job();
            Job testJobTwo = new Job();

            Assert.IsFalse(testJobOne.Id == testJobTwo.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            Assert.AreEqual("Product tester", testJob.Name);
            Assert.AreEqual("ACME", testJob.EmployerName.ToString());
            Assert.AreEqual("Desert", testJob.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", testJob.JobType.ToString());
            Assert.AreEqual("Persistence", testJob.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job testJobOne = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Job testJobTwo = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            Assert.IsFalse(testJobOne.Equals(testJobTwo));
        }

        [TestMethod]
        public void TestJobToStringForSpacing()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            string test = testJob.ToString();

            Assert.AreEqual("\n", test.Substring(0, 1));
            Assert.AreEqual("\n", test.Substring(test.Length - 1, 1));
        }

        [TestMethod]
        public void TestJobToStringForLayout()
        {
            Job testJob = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");

            string test = testJob.ToString();
            string[] testArray = test.Substring(1, test.Length - 1).Split("\n");

            Assert.AreEqual("ID: 3", testArray[0]);
            Assert.AreEqual("Name: Product tester", testArray[1]);
            Assert.AreEqual("Employer: ACME", testArray[2]);
            Assert.AreEqual("Location: Desert", testArray[3]);
            Assert.AreEqual("Position Type: Quality control", testArray[4]);
            Assert.AreEqual("Core Competency: Persistence", testArray[5]);
        }

        [TestMethod]
        public void TestJobToStringForEmptyField()
        {
            Job testJob = new Job("Product tester", "", "Desert", "Quality control", "Persistence");

            string test = testJob.ToString();
            string[] testArray = test.Substring(1, test.Length - 1).Split("\n");

            Assert.AreEqual("Employer: Data not available", testArray[2]);
        }
    }
}
