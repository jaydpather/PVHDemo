﻿using System;
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
    }
}
