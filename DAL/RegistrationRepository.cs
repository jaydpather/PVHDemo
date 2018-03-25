using System;
using System.Collections.Generic;
using System.Linq;
using Model;

namespace DAL
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private CodeCampDbContext _dbContext;

        //we are using dependency injection so that the repository can be unit tested. (repository does not instantiate DB Context)
        public RegistrationRepository(CodeCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ProgrammingLanguageModel> GetProgrammingLanguages()
        {
            return _dbContext.ProgrammingLanguagesMaster.ToList();
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
