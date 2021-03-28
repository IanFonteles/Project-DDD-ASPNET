using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces;
using ProjectDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Services {
    public class JuridicPersonService : ServiceBase<JuridicPerson>, IJuridicPersonService {
        private readonly IJuridicPersonRepository _juridicPersonRepository ;

        public JuridicPersonService(IJuridicPersonRepository juridicPersonRepository) : base(juridicPersonRepository) {
            _juridicPersonRepository = juridicPersonRepository;
        }

        public IEnumerable<JuridicPerson> SearchByName(string name) {
            return _juridicPersonRepository.SearchByName(name);
        }
    }
}
