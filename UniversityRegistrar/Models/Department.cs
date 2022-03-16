using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.CourseDepartmentEntity = new HashSet<CourseDepartment>();
    }

    public int DepartmentId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<CourseDepartment> CourseDepartmentEntity { get; set;}
  }
}