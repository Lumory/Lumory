using Lumory.Controllers.Companies;
using Lumory.Models;
using Lumory.Services.Companies;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Lumory.Tests.Controllers;

[TestFixture]
public class CompanyControllerTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
            //Test endpoint Post create a company 
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
                
                var mock = new Mock<CompanyService>();
                mock.Setup(c => c.CreateCompany(company)).Returns(returnCompany);
                
                //Act
                CompanyController companyController = new CompanyController(mock.Object);
                var result = companyController.Create(company);
                var okResult = result as OkObjectResult;

                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
        // Test endpoint Get by ID get company by ID
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
                
                var mock = new Mock<CompanyService>();
                mock.Setup(c => c.FindCompany(99999)).Returns(returnCompany);
                
                //Act
                CompanyController companyController = new CompanyController(mock.Object);
                var result = companyController.Find(99999);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            //Test endpoint Get all get all companies in DB
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
                
                var mock = new Mock<CompanyService>();
                mock.Setup(c => c.ListCompanies()).Returns(returnCompany);
                
                //Act
                CompanyController companyController = new CompanyController(mock.Object);
                var result = companyController.Get();
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            // Test endpoint Put update a company using ID
            public void UpdateCompanyTest()
            {
                //Arrange
                var oldCompany = new Company()
                    {
                        Id = 99999,
                        Name = "Company",
                        Kvk = 12345678,
                        Email = "Company@Company.nl",
                        Password = "TestPassword",
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

                var mock = new Mock<CompanyService>();
                mock.Setup(c => c.FindCompany(99999)).Returns(oldCompany);
                mock.Setup(c => c.UpdateCompany(oldCompany, newCompany)).Returns(newCompany);
                
                //Act
                CompanyController companyController = new CompanyController(mock.Object);
                var result = companyController.Update(99999, newCompany);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(200, okResult.StatusCode);
            }

        [Test]
            // Test endpoint Delete delete a company using ID
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
                
                var mock = new Mock<CompanyService>();
                mock.Setup(c => c.FindCompany(99999)).Returns(company);
                mock.Setup(c => c.DeleteCompany(company));
                
                //Act
                CompanyController companyController = new CompanyController(mock.Object);
                var result = companyController.Delete(99999);
                var okResult = result as OkObjectResult;
                
                //Assert
                Assert.IsNotNull(okResult);
                Assert.AreEqual(StatusCodes.Status200OK, okResult.StatusCode);
            }
            
                

    }
}