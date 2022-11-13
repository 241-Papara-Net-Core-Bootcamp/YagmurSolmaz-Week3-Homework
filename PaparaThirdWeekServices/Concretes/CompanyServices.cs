﻿using PaparaThirdWeek.Data.Abstracts;
using PaparaThirdWeek.Data.Concretes;
using PaparaThirdWeek.Domain.Entities;
using PaparaThirdWeek.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaparaThirdWeek.Services.Concretes
{
    public class CompanyServices : ICompanyService
    {
        private readonly IRepository<Company> _companyRepository;

        public CompanyServices(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        // GetAll, Post, Update ve Delete Methods

        //GetAllMethod
        public IEnumerable<Company> GetAll()
        {
            return _companyRepository.GetAll();
        }

        // Post Method
        public void Post(Company company)
        {
            _companyRepository.Add(company);
        }

        // Update Method
        public void Update(Company company)
        {
            _companyRepository.Update(company);
        }

        // Delete Method
        public void Delete(Company company)
        {
            _companyRepository.Remove(company);
        }

    }
}
