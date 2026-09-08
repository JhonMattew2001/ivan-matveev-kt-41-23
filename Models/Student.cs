using System.Diagnostics;

namespace IvanMatveevKT_41_23.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? MiddleName { get; set; }

        public int GroupId { get; set; }

        public bool IsDeleted { get; set; }

        public AcademicGroup Group { get; set; } = null!;

        public ICollection<Grade> Grades { get; set; }
            = new List<Grade>();

        public ICollection<Credit> Credits { get; set; }
            = new List<Credit>();
    }
}
