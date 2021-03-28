using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace ProjetoModeloDDD.Application {
    public class JuridicPersonAppService : AppServiceBase<JuridicPerson>, IJuridicPersonAppService {
        private readonly IJuridicPersonService _juridicPersonService;

        public JuridicPersonAppService(IJuridicPersonService juridicPersonService)
          : base(juridicPersonService) {
            _juridicPersonService = juridicPersonService;
        }

        public IEnumerable<JuridicPerson> SearchByName(string name) {
            return _juridicPersonService.SearchByName(name);
        }
    }
}
