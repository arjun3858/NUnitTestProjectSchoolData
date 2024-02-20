using ClassLibrary;
using Moq;

namespace TestProject
{
    [TestFixture]
    public class SchoolDataTests
    {
        [Test]
        public void Teacher_GetTeacherInfo_ShouldReturnCorrectInfo()
        {
            var teacher = new Teacher("Antony", "Math");
            var result = teacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("Antony teaches Math"));
        }

        [Test]
        public void Student_GetStudentInfo_ShouldReturnCorrectInfo()
        {
            var student = new Student("Raj", 10);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo("Raj is in grade 10"));
        }

        [Test]
        public void Subject_GetSubjectInfo_ShouldReturnCorrectInfo()
        {
            var subject = new Subject("History", 3);
            var result = subject.GetSubjectInfo();
            Assert.That(result, Is.EqualTo("History has 3 credits"));
        }

        [Test]
        public void MockingExample()
        {
            var teacher = new Teacher("MockedTeacher", "MockedSubject");
            var result = teacher.GetTeacherInfo();
            Assert.That(result, Is.EqualTo("MockedTeacher teaches MockedSubject"));

        }

        [Test]
        [TestCase("Antony", 8)]
        [TestCase("Raj", 9)]
        public void Student_GetStudentInfoWithData(string studentName, int gradeLevel)
        {
            var student = new Student(studentName, gradeLevel);
            var result = student.GetStudentInfo();
            Assert.That(result, Is.EqualTo($"{studentName} is in grade {gradeLevel}"));
        }
    }

}