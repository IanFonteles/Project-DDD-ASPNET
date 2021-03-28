using ProjectDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Interfaces {
    public interface IJuridicPersonRepository : IRepositoryBase<JuridicPerson> {

        IEnumerable<JuridicPerson> SearchByName(String name);
    }
}
