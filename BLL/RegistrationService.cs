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

        public static void InitializeMapper()
        {
            _autoMapperConfig = new MapperConfiguration(x =>
                {
                    x.CreateMap<RegistrationViewModel, RegistrationModel>().ForMember(model => model.ProgrammingLanguage, opt => opt.Ignore());
                    x.CreateMap<ProgrammingLanguageModel, ProgrammingLanguageViewModel>();
                });
            
        }

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

        public List<ProgrammingLanguageViewModel> GetProgrammingLanguages()
        {
            var models = _registrationRepository.GetProgrammingLanguages();

            var mapper = _autoMapperConfig.CreateMapper();
            return mapper.Map<List<ProgrammingLanguageViewModel>>(models);
        }
    }
}
