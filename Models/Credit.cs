namespace IvanMatveevKT_41_23.Models
{
    public class Credit
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public bool IsPassed { get; set; }

        public int AcademicYear { get; set; }

        public Student Student { get; set; } = null!;

        public Subject Subject { get; set; } = null!;
    }
}
