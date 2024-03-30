using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data.Models
{
    public class EvaluationItem
    {
        public int EvaluationItemId { get; set; }
        public string Name { get; set; } = default!;
        public int Weight { get; set; }
        public int CourseId { get; set; }
        public double? PossibleMarks { get; set; }
        public double? EarnedMarks { get; set; }
        [NotMapped]
        public double? Percentage => EarnedMarks / PossibleMarks * 100;
        public Course Course { get; set; } = default!;
        public EvaluationGroup? EvaluationGroup { get; set; }
    }
}