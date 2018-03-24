using System;
using Model;

namespace DAL
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private CodeCampDbContext _dbContext;

        public RegistrationRepository(CodeCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool SaveRegistration(RegistrationModel registrationModel)
        {
            var retVal = true;

            try
            {
                _dbContext.Registrations.Add(registrationModel);
                _dbContext.SaveChanges();
            }
            catch
            {
                //todo: log exception
                retVal = false;
            }

            return retVal;
        }
        
    }
}
