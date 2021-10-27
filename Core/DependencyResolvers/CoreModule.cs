using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;


namespace Core.DependencyResolvers
{
    public class CoreModule : ICoreModule
    {
        public void Load(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMemoryCache();
            serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //serviceCollection.AddSingleton<ICacheManager, MemoryCacheManager>();
            serviceCollection.AddSingleton<Stopwatch>();
            //builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            //builder.RegisterType<EfTeamDal>().As<ITeamDal>().SingleInstance();

            //builder.RegisterType<LeagueManager>().As<ILeagueService>().SingleInstance();
            //builder.RegisterType<EfLeagueDal>().As<ILeagueDal>().SingleInstance();

            //builder.RegisterType<MatchManager>().As<IMatchService>().SingleInstance();
            //builder.RegisterType<EfMatchDal>().As<IMatchDal>().SingleInstance();

            //builder.RegisterType<PlayerManager>().As<IPlayerService>().SingleInstance();
            //builder.RegisterType<EfPlayerDal>().As<IPlayerDal>().SingleInstance();

            //builder.RegisterType<UserManager>().As<IUserService>();
            //builder.RegisterType<EfUserDal>().As<IUserDal>();

            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();
           

            //builder.RegisterType<ContactManager>().As<IContactService>();
            //builder.RegisterType<EfContactDal>().As<IContactDal>();

        }
    }
}
