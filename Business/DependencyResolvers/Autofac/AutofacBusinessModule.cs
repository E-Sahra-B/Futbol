using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            builder.RegisterType<EfTeamDal>().As<ITeamDal>().SingleInstance();

            builder.RegisterType<LeagueManager>().As<ILeagueService>().SingleInstance();
            builder.RegisterType<EfLeagueDal>().As<ILeagueDal>().SingleInstance();

            builder.RegisterType<MatchManager>().As<IMatchService>().SingleInstance();
            builder.RegisterType<EfMatchDal>().As<IMatchDal>().SingleInstance();

            builder.RegisterType<PlayerManager>().As<IPlayerService>().SingleInstance();
            builder.RegisterType<EfPlayerDal>().As<IPlayerDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
