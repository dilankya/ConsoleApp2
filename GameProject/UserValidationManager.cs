using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear == 1998 && gamer.FirstName == "Dilan" && gamer.LastName == "Kaya" && gamer.IdentityNumber == 353535)
            {
                return true;
                }else
            {
                return false;
            }

        }
    }
}
