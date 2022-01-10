using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application;
using Application.Interfaces;
using Application.Interfaces.Mappers;
using Application.Mappers;
using Infraestructure.Data.Repositories;
using Infraestructure.CrossCutting.IOC;
using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;
using Domain.Service;

namespace Infraestructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServicePessoaFisica>().As<IApplicationServicePessoaFisica>();
            builder.RegisterType<ServicePessoaFisica>().As<IServicePessoaFisica>().SingleInstance().PreserveExistingDefaults();
            builder.RegisterType<RepositoryPessoaFisica>().As<IRepositoryPessoaFisica>();
            builder.RegisterType<MapperPessoaFisica>().As<IMapperPessoaFisica>();

            builder.RegisterType<ApplicationServiceMovimentacao>().As<IApplicationServiceMovimentacao>();
            builder.RegisterType<ServiceMovimentacao>().As<IServiceMovimentacao>();
            builder.RegisterType<RepositoryMovimentacao>().As<IRepositoryMovimentacao>();
            builder.RegisterType<MapperMovimentacao>().As<IMapperMovimentacao>();

            #endregion
        }
    }
}