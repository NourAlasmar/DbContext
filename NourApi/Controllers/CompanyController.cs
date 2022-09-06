using NourApi.Model;
using NourApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace NourApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        public ICompany _CompanyService;

        public CompanyController(ICompany companyService)
        {
            _CompanyService = companyService;
        }

        [HttpGet("GetAllCompany")]
        public async Task<ActionResult<List<Company>>> Get()
        {
            
            return  Ok(await _CompanyService.GetCompany());
        }

        [HttpGet("Getbyid/{id}")]
        public async Task<ActionResult<List<Company>>> Getbyid(int id)
        {
            return Ok(await _CompanyService.GetById(id));
        }

        [HttpPost("NewCompany")]
        public async Task<ActionResult<List<Company>>> NewCompany(Company newCompany)
        {
            return Ok(await _CompanyService.AddCompany(newCompany));
        }
        [HttpPut("UpdateCompany")]
        public async Task<ActionResult<List<Company>>> UpdateCompany(Company Upd)
        {
            return Ok(await _CompanyService.UpdateCompany(Upd));
        }
        [HttpDelete("DeleteCompany/{id}")]
        public async Task<ActionResult<List<Company>>> DeleteCompany(int id)
        {
            return Ok(await _CompanyService.DeleteCompany(id));
        }


    }
}

