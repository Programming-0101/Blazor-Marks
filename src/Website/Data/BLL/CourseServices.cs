using Microsoft.EntityFrameworkCore;
using WebApp.Data.DAL;
using WebApp.Data.Models;

namespace WebApp.Data.BLL;

public class CourseServices
{
    private readonly MyMarksContext _context;
    internal CourseServices(MyMarksContext context)
    {
        _context = context;
    }

    public List<Course> GetAllCourses()
    {
        return _context.Courses.Include(x => x.EvaluationItems).ToList();
    }

    public void AddCourse(Course course)
    {
        _context.Courses.Add(course);
        _context.SaveChanges();
    }

    public void DeleteCourse(int id)
    {
        _context.Courses.Remove(_context.Courses.Find(id)!);
        _context.SaveChanges();
    }   
}
