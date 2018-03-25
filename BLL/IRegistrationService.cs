using System;
using System.Collections.Generic;
using System.Text;
using ViewModel;

namespace BLL
{
    public interface IRegistrationService
    {
        void SaveRegistration(RegistrationViewModel registrationViewModel);
        List<ProgrammingLanguageViewModel> GetProgrammingLanguages();
    }
}
