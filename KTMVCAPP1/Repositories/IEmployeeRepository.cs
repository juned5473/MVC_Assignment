using KTMVCAPP1.Models;

namespace KTMVCAPP1.Repositories
{
    public interface IEmployeeRepository
    {

        List<Employee> GetAll();
        /*IEnumerable<Employee> GetEmployee();*/
        Employee GetEmployeeByID(int empId);
        void InsertEmployee(Employee emp);
        void DeleteEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
        void Save();



    }
}
