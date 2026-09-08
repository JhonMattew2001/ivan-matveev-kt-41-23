namespace IvanMatveevKT_41_23.Models
{
    public class AcademicGroup
    {
        public int Id { get; set; }

        public string GroupName { get; set; } = null!;

        public string Specialty { get; set; } = null!;

        public int Year { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Student> Students { get; set; }
            = new List<Student>();
    }
}
