using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CompanyManager : ICompanyServise
    {
        public void Add(Company company)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void Delete(Company company)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void Update(Company company)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }

}
}
