using System;
using ViewModel;
using Model;
using DAL;
using AutoMapper;
using System.Collections.Generic;

namespace BLL
{
    public class RegistrationService : IRegistrationService
    {
        private IRegistrationRepository _registrationRepository;
        private static MapperConfiguration _autoMapperConfig;

        //needed for auto mapper
        public static void InitializeMapper()
        {
            _autoMapperConfig = new MapperConfiguration(x =>
                {
                    x.CreateMap<RegistrationViewModel, RegistrationModel>().ForMember(model => model.ProgrammingLanguage, opt => opt.Ignore()); //no need to populate ProgrammingLanguage property on Model when mapping from ViewModel
                    x.CreateMap<ProgrammingLanguageModel, ProgrammingLanguageViewModel>();
                });
            
        }

        //we are using dependency injection so that the service can be unit tested. (service does not instantiate Registration Repository)
        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public void SaveRegistration(RegistrationViewModel registrationViewModel)
        {
            var mapper = _autoMapperConfig.CreateMapper();

            var model = mapper.Map<RegistrationModel>(registrationViewModel);

            var success = _registrationRepository.SaveRegistration(model);

            if(success)
            {
                registrationViewModel.StatusMessage = "Registration saved successfully.";
            }
            else
            {
                registrationViewModel.StatusMessage = "Unable to save registration. Please try again later.";
            }
        }

        //used to populate dropdown list:
        public List<ProgrammingLanguageViewModel> GetProgrammingLanguages()
        {
            var models = _registrationRepository.GetProgrammingLanguages();

            var mapper = _autoMapperConfig.CreateMapper();
            return mapper.Map<List<ProgrammingLanguageViewModel>>(models);
        }
    }
}
