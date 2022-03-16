

namespace UniversityRegistrar.Models
{
  public class CourseStudent
  {       
    public int CourseStudentId { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public virtual Student student { get; set; }
    //Virtual allows us to use lazy loading and override
    public virtual Course course { get; set; }
    public bool Completed { get; set; }
  }
}