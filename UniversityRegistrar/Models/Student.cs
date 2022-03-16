using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
    public class Student
    {
        public Student()
        {
            this.CourseStudentEntity = new HashSet<CourseStudent>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public string DateEnrolled {get; set; }


        public virtual ICollection<CourseStudent> CourseStudentEntity { get;}
    }
}