namespace IvanMatveevKT_41_23.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public int GradeValue { get; set; }

        public int AcademicYear { get; set; }

        public Student Student { get; set; } = null!;

        public Subject Subject { get; set; } = null!;
    }
}
