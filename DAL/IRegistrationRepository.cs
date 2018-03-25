using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace DAL
{
    public interface IRegistrationRepository
    {
        bool SaveRegistration(RegistrationModel registrationModel);
        List<ProgrammingLanguageModel> GetProgrammingLanguages();
    }
}
