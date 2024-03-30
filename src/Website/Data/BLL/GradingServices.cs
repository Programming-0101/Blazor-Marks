using Microsoft.EntityFrameworkCore;
using WebApp.Data.DAL;
using WebApp.Data.Models;

namespace WebApp.Data.BLL;

public class GradingServices
{
    private readonly MyMarksContext _context;
    internal GradingServices(MyMarksContext context)
    {
        _context = context;
    }
    public List<EvaluationItem> GetAllEvaluationItems()
    {
        return _context.EvaluationItems.Include(x => x.Course).ToList();
    }

    public EvaluationItem? GetEvaluationItem(int id)
    {
        return _context.EvaluationItems.Find(id);
    }
}
