using System.Collections;
using TmLms.TM;
using TmLms.Users;

namespace TMUnitTest
{
    public class ModuleTests
    {
        /// <summary>
        /// Module Creation Test
        /// </summary>
        /// <param name="course"></param>
        /// <param name="moduleName"></param>
        /// <param name="moduleDescription"></param>
        /// <param name="credits"></param>
        /// <param name="adminList"></param>
        /// <param name="studentList"></param>
        /// <param name="instructorList"></param>

        [Theory]
        [ClassData(typeof(CourseData))]
        [ClassData(typeof(Administrator))]
        [ClassData(typeof(Student))]
        [ClassData(typeof(Instructor))]
        public void ModuleCreateTest(Course course, string moduleName, string moduleDescription, int credits, Administrator[] adminList, Student[] studentList, Instructor[] instructorList) 
        {
            //Arrange
            int moduleID = 0;

            Instructor instructor1 = new Instructor
            {
                InstructorName = "Mr Poo Poo Head",
                ID = 1,
            };

            Module module = new Module(course, moduleName, moduleDescription, credits, adminList, studentList, instructorList);

            //Act
            module.Instructors.Add(1, instructor1);
            Program.tmEngine.ModuleDictionary.Add(moduleID, module);
            moduleID++;

            //Assert

            Assert.True(true);
        }


        // Test to add unique instructora
        // A module can have multiple instructors but should
        // only be allowed to be added once.

        /// <summary>
        /// Test to add an Instructor to a module
        /// </summary>
        /// <param name="module"></param>
        /// <param name="instructors"></param>

        [Theory]
        public void AddInstructor(Module module, Instructor[] instructors) 
        {

        }
    }

    public class CourseData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {
                new Course
                {
                    Name = "TestCourse",
                    Description = "Test",
                    Level = 5,
                    Credits = 20,
                }
            };
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
