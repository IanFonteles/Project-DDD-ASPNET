
using AutoMapper;
using CrudDDD.MVC.ViewModels;
using ProjectDDD.Domain.Entities;

namespace ProjetoModeloDDD.MVC.AutoMapper {
    public class DomainToViewModelMappingProfile : Profile {
        public override string ProfileName {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure() {
            Mapper.CreateMap<FisicPersonViewModel, FisicPerson>();
            Mapper.CreateMap<JuridicPersonViewModel, JuridicPerson>();

        }
    }
}