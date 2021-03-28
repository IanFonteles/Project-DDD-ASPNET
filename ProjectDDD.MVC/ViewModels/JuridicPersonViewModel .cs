using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudDDD.MVC.ViewModels {
    public class JuridicPersonViewModel {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo de 150 cáracteres")]
        [MinLength(2, ErrorMessage = "Máximo de 2 cáracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DisplayName("Data de Nascimento")]
        //public DateTime BirthDate { get; set; }

        [Display(Name = "CNPJ")]
        [MaxLength(11, ErrorMessage = "Máximo de 11 cáracteres")]
        public string CNPJ { get; set; }

        [Display(Name = "Telefone")]
        [MaxLength(15, ErrorMessage = "Máximo de 15 cáracteres")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Celular")]
        [MaxLength(15, ErrorMessage = "Máximo de 15 cáracteres")]
        public string CellNumber { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo de 100 cáracteres")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegisterDate { get; set; }

        [DisplayName("Endereço")]
        public string Address { get; set; }

        [DisplayName("Descrição")]
        public string Description { get; set; }

        [DisplayName("Ativo")]
        public bool Active { get; set; }
    }
}
