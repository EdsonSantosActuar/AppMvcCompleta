using DevEs.Business.Models;
using AutoMapper;
using DevEs.App.ViewModels;

namespace DevEs.App.AutoMapper
{
    public class Config : Profile
    {
        public Config()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
        }
    }
}
