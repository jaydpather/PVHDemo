using System;
using ViewModel;
using Model;
using DAL;

namespace BLL
{
    public class RegistrationService : IRegistrationService
    {
        private IRegistrationRepository _registrationRepository;

        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public void SaveRegistration(RegistrationViewModel registrationViewModel)
        {
            var model = MapRegistration(registrationViewModel);
            _registrationRepository.SaveRegistration(model);
        }

        private RegistrationModel MapRegistration(RegistrationViewModel viewModel)
        {
            RegistrationModel retVal = new RegistrationModel
            {
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                AddressLine1 = viewModel.AddressLine1
            };

            return retVal;
        }
    }
}
