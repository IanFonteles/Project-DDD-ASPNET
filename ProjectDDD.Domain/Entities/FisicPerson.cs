using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Entities {
    public class FisicPerson : Client {
        public string CPF { get; set; }
        public string LastName { get; set; }
        //public DateTime BirthDate { get; set; }
    }
}
