using AppMVC.ViewModel;
using AutoMapper;
using Business.Models.Fornecedores;
using Business.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AppMVC.App_Start
{
    public class AutoMapperConfig
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = Assembly.GetExecutingAssembly()
                                   .GetTypes()
                                   .Where(x => typeof(Profile)
                                   .IsAssignableFrom(x));

            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles)
                {
                    cfg.AddProfile(Activator.CreateInstance(profile) as Profile);
                }
            });

        }

        public class AutoMapperProfile : Profile
        {

            public AutoMapperProfile()
            {
                CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
                CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
                CreateMap<Produto, ProdutoViewModel>().ReverseMap();

            }

        }
    }
}