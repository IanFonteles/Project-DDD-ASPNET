using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Interfaces.Services {
    public interface IJuridicPersonService : IServiceBase<JuridicPerson> {
        IEnumerable<JuridicPerson> SearchByName(String name);
    }
}
