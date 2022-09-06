using Microsoft.EntityFrameworkCore;
using NourApi.Model;

namespace NourApi.Service
{
    public class CompanyService : ICompany
    {

        public readonly EmpContext _context;

        public CompanyService (EmpContext dbContext) { 
            _context = dbContext;
        }


        public async Task<List<Company>> AddCompany(Company newCompany)
        {

            _context.Companys.Add(newCompany);
            await _context.SaveChangesAsync();
            return await _context.Companys.ToListAsync();
        }

        public async Task<List<Company>> DeleteCompany(int id)
        {
            Company Comp = _context.Companys.First(x => x.CompanyId == id);
            _context.Companys.Remove(Comp);
            await _context.SaveChangesAsync();
            return await _context.Companys.ToListAsync();
        }

        public async Task<Company> GetById(int id)
        {
            
            return await _context.Companys.FirstAsync(x => x.CompanyId == id);

        }

        public async Task<List<Company>> GetCompany()
        {
            
            return await _context.Companys.ToListAsync(); ;
        }

        public async Task<List<Company>> UpdateCompany(Company updateCompany)
        {
            Company c1 = _context.Companys.First(x=> x.CompanyId == updateCompany.CompanyId);
            c1.Name=updateCompany.Name;
            c1.Age = updateCompany.Age;
            c1.CompanyId = updateCompany.CompanyId;
            await _context.SaveChangesAsync();
            return await _context.Companys.ToListAsync();

        }
    }
}
