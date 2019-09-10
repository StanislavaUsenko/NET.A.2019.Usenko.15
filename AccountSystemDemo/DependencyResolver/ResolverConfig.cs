using BLL.Interface.Entities;
using BLL.Interface.Interfaces;
using BLL.ServiceImplementation;
using BLL.Mappers;
using DAL.Interface.Interfaces;
using DAL.Repositories;
using Ninject;

namespace DependencyResolver
{
    public static class ResolverConfig
    {
        public static void ConfigurateResolver(this IKernel kernel)
        {
            kernel.Bind<IService<BLL.Interface.Entities.BankAccount>, IConverter<BLL.Interface.Entities.BankAccount, DAL.Interface.DTO.BankAccount>, IConverter<DAL.Interface.DTO.BankAccount, BLL.Interface.Entities.BankAccount>>().To<StandartBankAccountService>();
            //kernel.Bind<IRepository>().To<FakeRepository>();
            kernel.Bind<IRepository<DAL.Interface.DTO.BankAccount>>().To<BinaryRepository>().WithConstructorArgument("test.bin");
            kernel.Bind<IConverter<BLL.Interface.Entities.BankAccount, DAL.Interface.DTO.BankAccount>>().To<ConvertBLLBankAccountToDALBankAccount>();
            kernel.Bind<IConverter<DAL.Interface.DTO.BankAccount, BLL.Interface.Entities.BankAccount>>().To<ConvertDALBankAccountToBLLBankAccount>();
            //kernel.Bind<IAccountNumberCreateService>().To<AccountNumberCreator>().InSingletonScope();
            //kernel.Bind<IApplicationSettings>().To<ApplicationSettings>();
        }
    }
}
