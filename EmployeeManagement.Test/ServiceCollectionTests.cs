﻿using EmployeeManagement.DataAccess.Services;
using EmployeeManagement.Test;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;


// added test comment
// another comment
// dasldlkaslkd

//AnotherTestClass z

// add test commit
namespace EmployeeManagement.Test
{
    public class ServiceCollectionTests
    {
        [Fact]
        public void RegisterDataServices_Execute_DataServicesAreRegistered()
        {
            // Arrange
            var serviceCollection = new ServiceCollection();
            var configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(
                    new Dictionary<string, string> {
                        {"ConnectionStrings:EmployeeManagementDB", "AnyValueWillDo"}})
                .Build();

            // Act
            serviceCollection.RegisterDataServices(configuration);
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // Assert
            Assert.NotNull(
                serviceProvider.GetService<IEmployeeManagementRepository>());
            Assert.IsType<EmployeeManagementRepository>(
                serviceProvider.GetService<IEmployeeManagementRepository>());
        }
    }
}
