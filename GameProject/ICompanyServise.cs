using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICompanyServise
    {
        void Add(Company company);
        void Update(Company company);
        void Delete(Company company);
    }
}
