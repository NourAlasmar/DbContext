
using Microsoft.EntityFrameworkCore;
using NourApi.Model;

namespace NourApi.Service
{
    public class EmployeeService : IEmployee
    {
        
        private readonly EmpContext _context ;

        public EmployeeService(EmpContext dbContext)
        {
            _context = dbContext;
        }

        public async Task<List<Employee>> AddEmployee(Employee newEmployee)
        {
            _context.Employees.Add(newEmployee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> DeleteEmployee(int id)
        {
            Employee emp1 = _context.Employees.First(x => x.id == id);
            _context.Employees.Remove(emp1);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {

            return await _context.Employees.FirstAsync(x => x.id == id);
        }

        public async Task<List<Employee>> GetEmployee()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> UpdateEmployee(Employee updateEmployee)
        {
            Employee emp1 = _context.Employees.First(x => x.id == updateEmployee.id);
            emp1.Name=updateEmployee.Name;
            emp1.Location = updateEmployee.Location;
            emp1.CompanyId=updateEmployee.CompanyId;
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }
    }
}
