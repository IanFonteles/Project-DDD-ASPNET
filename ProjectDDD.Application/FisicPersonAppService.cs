using ProjectDDD.Application.Interface;
using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces.Services;
using System.Collections.Generic;


namespace ProjetoModeloDDD.Application {
    public class FisicPersonAppService : AppServiceBase<FisicPerson>, IFisicPersonAppService {
        private readonly IFisicPersonService _fisicPersonService;

        public FisicPersonAppService(IFisicPersonService fisicPersonService)
          : base(fisicPersonService) {
            _fisicPersonService = fisicPersonService;
        }

        public IEnumerable<FisicPerson> SearchByName(string name) {
            return _fisicPersonService.SearchByName(name);
        }
    }
}
