using Bogus;
using Microsoft.EntityFrameworkCore;
using SecurePoll_BE.Models;

namespace SecurePoll_BE.Seeders;
public static class UserSeeder
{
    public static void Seed(ModelBuilder modelBuilder, int amout)
    {

        var userFaker = new Faker<User>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.Name, f => f.Name.FirstName()) 
            .RuleFor(u => u.LastName, f => f.Name.LastName()) 
            .RuleFor(u => u.DocumentTypeId, f => f.PickRandom(1, 2, 3, 4, 5, 6, 7)) 
            .RuleFor(u => u.IdentificationNumber, f => f.Random.Replace("#########")) 
            .RuleFor(u => u.RoleId, f => f.PickRandom(2, 3, 4)) 
            .RuleFor(u => u.Email, f => f.Internet.Email()) 
            .RuleFor(u => u.Password, f => f.Internet.Password()) 
            .RuleFor(u => u.OauthGoogle, f => f.Random.Bool() ? f.Internet.UserName() : null); 


        var users = userFaker.Generate(amout); 

        modelBuilder.Entity<User>().HasData(users);
    }
}
