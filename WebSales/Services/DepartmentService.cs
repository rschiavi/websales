using System.Linq;
using System.Collections.Generic;
using WebSales.Models;

namespace WebSales.Services
{
    public class DepartmentService
    {
        private readonly WebSalesContext _context;

        public DepartmentService(WebSalesContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(dep => dep.Name).ToList();
        }
    }
}
