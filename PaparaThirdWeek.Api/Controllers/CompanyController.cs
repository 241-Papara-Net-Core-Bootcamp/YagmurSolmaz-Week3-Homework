using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using PaparaThirdWeek.Services.DTOs;

namespace PaparaThirdWeek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
                
        [HttpPost]
        [Consumes("application/json")]
        public IActionResult Add(Company company)
        {
            _companyService.Post(company);
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _companyService.GetAll();
            return Ok(result);
        }
       
        [HttpDelete]
        [Consumes("application/json")]
        public IActionResult Delete(Company company)
        {
            _companyService.Delete(company);
            return Ok();
        }

        [HttpPut]
        [Consumes("application/json")]
        public IActionResult Update(Company company)
        {
            _companyService.Update(company);
            return Ok();
        }
    }
}
