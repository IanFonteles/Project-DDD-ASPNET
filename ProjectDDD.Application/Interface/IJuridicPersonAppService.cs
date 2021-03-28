using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Application.Interface {
    public interface IJuridicPersonAppService : IAppServiceBase<JuridicPerson> {
        IEnumerable<JuridicPerson> SearchByName(String name);

    }
}
