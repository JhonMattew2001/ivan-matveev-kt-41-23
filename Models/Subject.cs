namespace IvanMatveevKT_41_23.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public SubjectDirection Direction { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Grade> Grades { get; set; }
            = new List<Grade>();

        public ICollection<Credit> Credits { get; set; }
            = new List<Credit>();
    }
}
