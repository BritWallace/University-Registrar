using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
public class Course
{
    public Course()
    {
        this.CourseStudentEntity = new HashSet<CourseStudent>();
        this.CourseDepartmentEntity = new HashSet<CourseDepartment>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public string CourseNumber { get; set; }
    public int DepartmentId { get; set; }
    public virtual ICollection<CourseStudent> CourseStudentEntity { get; set; }
    public virtual ICollection<CourseDepartment> CourseDepartmentEntity { get; set; }
}
}