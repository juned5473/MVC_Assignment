using AutoMapper;
using KTMVCAPP1.Data;
using KTMVCAPP1.Models;
using Microsoft.EntityFrameworkCore;

namespace KTMVCAPP1.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly EmployeeDbContext _context;
        

        public EmployeeRepository(EmployeeDbContext context,IMapper mapper)
        {
            _context = context;
          
        }

        public void DeleteEmployee(Employee emp)
        {
            _context.Employees.Remove(emp);
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEmployeeByID(int Id)
        {
            return _context.Employees.Where(x => x.Id == Id).FirstOrDefault();
        }

        public void InsertEmployee(Employee emp)
        {
            _context.Employees.Add(emp);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee emp)
        {
            _context.Employees.Update(emp);
        }
    }
}
