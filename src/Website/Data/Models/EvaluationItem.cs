namespace WebApp.Data.Models
{
    public class EvaluationItem
    {
        public int EvaluationItemId { get; set; }
        public string Name { get; set; } = default!;
        public int Weight { get; set; }
        public int CourseId { get; set; }
        public int? PossibleMarks { get; set; }
        public int? EarnedMarks { get; set; }
        public Course Course { get; set; } = default!;
        public EvaluationGroup? EvaluationGroup { get; set; }
    }
}