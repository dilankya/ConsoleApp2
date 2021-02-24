using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {

            GamerManager gamermanager = new GamerManager(new NewEDevletUserValidationManager());
            gamermanager.Add(new Gamer { Id = 1, BirthYear = 1998, FirstName = "Dilan", LastName = "Kaya", IdentityNumber = 353535 });

            Company company = new Company();
            company.CompanyId = 1;
            company.CompanyName = "Anneler günü";
            company.DiscountRate = 0.50;
            company.EndDate = new DateTime(2021, 05, 09);
            company.StartDate= new DateTime(2021,05,10);

            CompanyManager companyManager = new CompanyManager();
            companyManager.Add(company);
            companyManager.Update(company);

       
        
        }
    }
}
