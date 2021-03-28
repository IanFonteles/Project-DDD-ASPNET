
using AutoMapper;
using CrudDDD.MVC.ViewModels;
using ProjectDDD.Domain.Entities;

namespace ProjetoModeloDDD.MVC.AutoMapper {
    public class ViewModelToDomainMappingProfile : Profile {
        public override string ProfileName {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure() {
            Mapper.CreateMap<FisicPerson, FisicPersonViewModel>();
            Mapper.CreateMap<JuridicPerson, JuridicPersonViewModel>();

        }
    }
}