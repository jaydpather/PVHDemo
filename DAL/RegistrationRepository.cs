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

        public void SaveRegistration(RegistrationModel registrationModel)
        {

        }
        
    }
}
