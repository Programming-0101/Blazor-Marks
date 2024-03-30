namespace WebApp.Data.Models
{
    public class EvaluationGroup
    {
        public int EvaluationGroupId { get; set; }
        public string Name { get; set; } = default!;
        public bool IsGroupPassRequired { get; set; }
        public int CourseId { get; set; }
        public ICollection<EvaluationItem> EvaluationItems { get; set; } = new HashSet<EvaluationItem>();
    }
}