using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirsName=="Yunus" && gamer.LastName=="İçoğlu"&& gamer.BirthYear==2001&&gamer.IdentityNumber==142536)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
