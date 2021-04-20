using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, FirsName = "Yunus", LastName = "İçoğlu", BirthYear = 2001, IdentityNumber = 142536 });
        }
    }
}