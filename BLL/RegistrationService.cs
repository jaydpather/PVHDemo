using System;
using ViewModel;
using Model;
using DAL;
using AutoMapper;

namespace BLL
{
    public class RegistrationService : IRegistrationService
    {
        private IRegistrationRepository _registrationRepository;
        private static MapperConfiguration _autoMapperConfig;

        public static void InitializeMapper()
        {
            _autoMapperConfig = new MapperConfiguration(x => x.CreateMap<RegistrationViewModel, RegistrationModel>());
        }

        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public void SaveRegistration(RegistrationViewModel registrationViewModel)
        {
            //todo: server side validation (in case user has javascript turned off)
            var mapper = _autoMapperConfig.CreateMapper();
            var model = mapper.Map<RegistrationModel>(registrationViewModel);

            _registrationRepository.SaveRegistration(model);
        }
    }
}
