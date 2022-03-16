namespace UniversityRegistrar.Models
{
  public class CourseDepartment
  {
    public int CourseDepartmentId { get; set; }
    public int CourseId { get; set; }
    public int DepartmentId { get; set; }
    public virtual Course course { get; set; }
    public virtual Department department {get; set; }
  }
}