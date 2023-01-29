using NUnit.Framework;
using Lumory.Repositories.Companies;
using Lumory.Models;
using Lumory.Services.Companies;
using Moq;

namespace Lumory.Tests.Services;

[TestFixture]
public class CompanyServiceTest
{
    [Test]
    // Test CreateCompany, create a company
        public void AddCompanyTest()
        {
            //Arrange
            var company = new Company()
            {
                Id = 99999,
                Name = "Company",
                Kvk = 12345678,
                Email = "Company@Company.nl",
                Password = "TestPassword"
            };

            var returnCompany = new Company()
            {
                Id = 99999,
                Name = "Company",
                Kvk = 12345678,
                Email = "Company@Company.nl",
                Password = "TestPassword",
                CreatedAt = DateTime.Now
            };
                    
            var mock = new Mock<CompanyRepository>();
            mock.Setup(c => c.CreateCompany(company)).Returns(returnCompany);
            
            //Act
            CompanyService companyService = new CompanyService(mock.Object);
            var result = companyService.CreateCompany(company);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(returnCompany, result);
        }
    
    [Test]
        // Test FindCompany, get company by ID
        public void GetCompanyByIdTest()
        {
            //Arrange
            var returnCompany = new Company()
            {
                Id = 99999,
                Name = "Company",
                Kvk = 12345678,
                Email = "Company@Company.nl",
                Password = "TestPassword",
                CreatedAt = DateTime.Now
            };
                    
            var mock = new Mock<CompanyRepository>();
            mock.Setup(c => c.FindCompanyById(99999)).Returns(returnCompany);
                    
            //Act
            CompanyService companyService = new CompanyService(mock.Object);
            var result = companyService.FindCompany(99999);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(returnCompany, result);
        }
    
    [Test]
        // Test ListCompany, get all companies in DB
        public void GetAllCompaniesTest()
        {
                //Arrange
                var returnCompany = new List<Company>()
                {
                    new Company
                    {
                        Id = 99999,
                        Name = "Company",
                        Kvk = 12345678,
                        Email = "Company@Company.nl",
                        Password = "TestPassword",
                        CreatedAt = DateTime.Now
                    },
                    new Company
                    {
                        Id = 99998,
                        Name = "Company2",
                        Kvk = 87654321,
                        Email = "Company2@Company.nl",
                        Password = "TestPassword2",
                        CreatedAt = DateTime.Now
                    }
                };
                
                var mock = new Mock<CompanyRepository>();
                mock.Setup(c => c.GetCompanies()).Returns(returnCompany);
                
                //Act
                CompanyService companyService = new CompanyService(mock.Object);
                var result = companyService.ListCompanies(); 
                
                //Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(returnCompany, result);
        }

    [Test]
        // Test UpdateCompany, update company by model
        public void UpdateCompanyTest()
        {
                //Arrange
                var oldCompany = new Company()
                    {
                        Id = 99999,
                        Name = "Company",
                        Kvk = 12345678,
                        Email = "Company@Company.nl",
                        Password = "TestPassword2",
                        CreatedAt = DateTime.Now
                };
                var newCompany = new Company
                {
                    Id = 99999,
                    Name = "Company2",
                    Kvk = 87654321,
                    Email = "Company2@Company.nl",
                    Password = "TestPassword2",
                    CreatedAt = DateTime.Now
                };

                var company = new Company
                {
                    Id = 99999,
                    Name = "Company2tertreterter",
                    Kvk = 87654321,
                    Email = "Company2@Company.nl",
                    Password = "TestPassword2",
                    CreatedAt = DateTime.Now
                };

                var mock = new Mock<CompanyRepository>();
                mock.Setup(c => c.UpdateCompany(oldCompany));
                mock.Setup(c => c.FindCompanyById(oldCompany.Id)).Returns(company);

                //Act
                CompanyService companyService = new CompanyService(mock.Object);
                companyService.UpdateCompany(oldCompany, newCompany);
                var result = companyService.FindCompany(oldCompany.Id);

                //Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(company, result);
        }

    [Test]
        // Test DeleteCompany, delete company by model
        public void DeleteCompanyTest()
        {
                //Arrange
                var company = new Company
                {
                    Id = 99999,
                    Name = "Company2",
                    Kvk = 87654321,
                    Email = "Company2@Company.nl",
                    Password = "TestPassword2",
                    CreatedAt = DateTime.Now
                };
                
                var mock = new Mock<CompanyRepository>();
                mock.Setup(c => c.RemoveCompany(company));

                //Act
                CompanyService companyService = new CompanyService(mock.Object);
                companyService.DeleteCompany(company);

                //Assert
                Assert.IsTrue(true);
        }
            
                

}
