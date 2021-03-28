using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDDD.Domain.Entities {
    public abstract class Client {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }

    }
}
