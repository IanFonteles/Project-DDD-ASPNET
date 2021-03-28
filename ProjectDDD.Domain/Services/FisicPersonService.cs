using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces;
using ProjectDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Services {
    public class FisicPersonService : ServiceBase<FisicPerson>, IFisicPersonService {
        private readonly IFisicPersonRepository _fisicPersonRepository ;

        public FisicPersonService(IFisicPersonRepository fisicPersonRepository) : base(fisicPersonRepository) {
             _fisicPersonRepository = fisicPersonRepository;
        }

        IEnumerable<FisicPerson> IFisicPersonService.SearchByName(string name) {
            return _fisicPersonRepository.SearchByName(name);
        }
    }
}
