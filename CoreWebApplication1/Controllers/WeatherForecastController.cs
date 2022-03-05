using CoreWebApplication1.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    
    private readonly BaseContext _context;

    public EmployeeController(BaseContext context)
    {

        _context = context;
    }

    [HttpGet]
    
    // 17. Napisz zapytanie wyświetlające nazwiska pracowników, których nazwiska składają się z dokładnie 5 znaków. [employees]
    // public IEnumerable<Employee> GetEmployee()
    // {
    //     var result = _context.Employees
    //         .Where(e => e.LastName.Length < 6)
    //         .ToList();
    //     return result;
    // }
    
    // 21. Napisz zapytanie, aby uzyskać job_id i ID(s) tych pracowników, którzy pracują na danym stanowisku.
    // public IEnumerable<Employee> GetEmployee()
    // {
    //     var result = _context.Employees
    //         .GroupBy(e => e.JobId)
    //         .Select(e => e);
    //     
    //     return result;
    // }
    
    //22. Napisz zapytanie wyświetlające imię, nazwisko oraz pensję osób, które pracują w dziale 60 || 90 || 110 || 120, a ich pensja jest spoza przedziału 7000 - 8000, wynik posortuj maqlejąco. [employees]
    // public IEnumerable<Employee> GetEmployee()
    // {
    //     var result = _context.Employees
    //         .Where(e => e.DepartmentId == 60 || e.DepartmentId == 90 || e.DepartmentId == 110 || e.DepartmentId == 120)
    //         .Where(e => e.Salary < 7000 || e.Salary > 8000)
    //         .OrderByDescending(e => e.FirstName)
    //         .Select(e => e)
    //         .ToList();
    //     
    //     
    //     
    //     return result;
    // }
    
    //25. Napisz zapytanie wyświetlające imie kazdego pracownika, którzy mają zarówno "b" jak i "c" w swoim imieniu. [employees]
    // public IEnumerable<Employee> GetEmployee()
    // {
    //     var result = _context.Employees
    //         .Where(e => e.FirstName.ToLower().Contains("b") && e.FirstName.ToLower().Contains("c"))
    //         .Select(e => e)
    //         .ToList();
    //
    //
    //
    //     return result;
    // }
    
    //28. Napisz zapytanie wyświetlające nazwisko, stanowisko oraz wynagrodzenie dla wszystkich pracowników, których stanowisko to IT_PROG lub SH_CLERK, a wynagrodzenie nie jest równe 4500, 10000 lub 15000, wynik posortuj rosnąco. [employees]
    public IEnumerable<Employee> GetEmployee()
    {
        var result = _context.Employees
            .Where(e => e.JobId == "IT_PROG" || e.JobId == "SH_CLERK")
            .Where(e => e.Salary != 4500 && e.Salary != 10000 && e.Salary != 15000)
            .OrderBy(e => e.JobId)
            .Select(e => e)
            .ToList();


        return result;
    }
}