using ProjectDDD.Domain.Entities;
using ProjectDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Infra.Data.Repositories {
    public class JuridicPersonRepository : RepositoryBase<JuridicPerson>, IJuridicPersonRepository {
        public IEnumerable<JuridicPerson> SearchByName(string name) {
            return Db.JuridicPersons.Where(p => p.Name == name);
        }
    }
}

