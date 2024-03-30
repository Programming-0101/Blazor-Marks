using WebApp.Data.DAL;

namespace WebApp.Data.BLL;

public class CourseServices
{
    private readonly MyMarksContext _context;
    internal CourseServices(MyMarksContext context)
    {
        _context = context;
    }
}
