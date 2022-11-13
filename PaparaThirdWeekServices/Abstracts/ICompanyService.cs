using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.DTOs;
using System.Collections.Generic;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PaparaThirdWeek.Services.Abstracts
{
    public interface ICompanyService
    {
        // GetAll, Post, Update ve Delete Methods
        IEnumerable<Company> GetAll();
        void Post(Company company);
        void Update(Company company);
        void Delete(Company company);
        
    }
}
