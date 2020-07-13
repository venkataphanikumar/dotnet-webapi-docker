using System;
using dotnet_webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

public class DataGenerator
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new PersonContext(
            serviceProvider.GetRequiredService<DbContextOptions<PersonContext>>()))
        {
            context.Persons.AddRange(
                new Person
                {
                    Id = 1,
                    FirstName = "Albert",
                    LastName = "Einstein",
                    JobTitle =  "theoretical physicist"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Isaac",
                    LastName = "Newton",
                    JobTitle =  "mathematician"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Nikola",
                    LastName = "Tesla",
                    JobTitle = "inventor"
                });

            context.SaveChanges();
        }
    }
}