using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public interface IRegistrationRepository
    {
        void SaveRegistration(RegistrationModel registrationModel);
    }
}
