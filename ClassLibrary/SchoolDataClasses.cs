using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
    {
        public class Student
        {
            public string Name { get; set; }
            public int GradeLevel { get; set; }

            public Student(string name, int gradeLevel)
            {
                Name = name;
                GradeLevel = gradeLevel;
            }

            public string GetStudentInfo()
            {
                return $"{Name} is in grade {GradeLevel}";
            }
        }
    public class Subject
    {
        public string Name { get; set; }
        public int Credits { get; set; }

        public Subject(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }

        public string GetSubjectInfo()
        {
            return $"{Name} has {Credits} credits";
        }
    }
    public class Teacher
    {
        public virtual string Name { get; set; }
        public string SubjectTaught { get; set; }

        public Teacher(string name, string subjectTaught)
        {
            Name = name;
            SubjectTaught = subjectTaught;
        }

        public string GetTeacherInfo()
        {
            return $"{Name} teaches {SubjectTaught}";
        }
    }
}


