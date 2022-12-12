namespace TMUnitTest
{
    public class CourseTests
    {
        /// <summary>
        /// A test to check that Level 4 and 5 cannot add more than the require module credits
        /// </summary>
        /// <param name="credits"></param>
        /// <param name="level"></param>
        [Theory]
        [InlineData(40, 4)]
        [InlineData(60, 5)]
        public void NoOptionalAllowedPassOne(int credits, int level)
        {
            //Arrange

            //Act

            //Assert

        }

        /// <summary>
        /// A test to check that Level 6 cannot add more that 100 optional module credits
        /// </summary>
        [Fact]
        public void NoOptionalAllowedPassTwo()
        {
            //Arrange

            //Act

            //Assert
        }

        /// <summary>
        /// A test to make sure that a course does not exceed 360 Credits.
        /// The course class should only add modules as core or option
        /// Everytime a module is added the course should add all core module credits
        /// and make sure they do not exceedd 360. If an optional module exists it should
        /// only be added in the credit count for the appropriate level. If an optional 
        /// </summary>
        [Theory]
        [InlineData(20, true, 4)]
        [InlineData(20, false, 4)]
        [InlineData(20, true, 5)]
        [InlineData(20, false, 5)]
        [InlineData(20, true, 6)]
        [InlineData(20, false, 6)]
        public void NotExceedingCredits(int Credits, bool IsCore, int Level)
        {
            //Arrange

            //Act

            //Assert
        }
    }
}