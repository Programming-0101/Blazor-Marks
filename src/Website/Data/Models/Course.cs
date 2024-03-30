namespace WebApp.Data.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Number { get; set; } = default!;
        public string Name { get; set; } = default!;
        public int Credits { get; set; }
        public bool IsFinished { get; set; }     
        public ICollection<EvaluationItem> EvaluationItems { get; set; } = new HashSet<EvaluationItem>();
    }
}