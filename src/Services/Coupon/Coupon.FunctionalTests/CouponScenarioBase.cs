using Autofac.Extensions.DependencyInjection;
using Coupon.FunctionalTests.Base;
using Coupon.API.Infrastructure.Repositories;

namespace Coupon.FunctionalTests;

public class CouponScenariosBase
{
    public TestServer CreateServer()
    {
        var path = Assembly.GetAssembly(typeof(CouponScenariosBase))
            .Location;

        //var hostBuilder = new HostBuilder()
        //    .UseContentRoot(Path.GetDirectoryName(path))
        //    .UseServiceProviderFactory(new AutofacServiceProviderFactory())
        //    .ConfigureAppConfiguration(cb =>
        //    {
        //        cb.AddJsonFile("appsettings.json", optional: false)
        //        .AddEnvironmentVariables();
        //    })
        //    .ConfigureWebHost(webBuilder => webBuilder
        //                            .UseTestServer()
        //                            .Configure(app => { })
        //                            .UseStartup<CouponTestsStartup>()
        //                            );
        ////.UseStartup<Startup>();

        //var host = hostBuilder.Start();
        //host.SeedDatabaseStrategy<CouponContext>(context => new CouponSeed().SeedAsync(context).Wait());
        //var testServer = host.GetTestServer();

        //return testServer;

        var hostBuilder = new WebHostBuilder()
            .UseContentRoot(Path.GetDirectoryName(path))
            .ConfigureAppConfiguration(cb =>
            {
                cb.AddJsonFile("appsettings.json", optional: false)
                .AddEnvironmentVariables();
            }).UseStartup<CouponTestsStartup>();

        return new TestServer(hostBuilder);
    }

    public static class Get
    {
        public static string CouponByCode(String code)
        {
            return $"api/v1/coupon/{code}";
        }
    }
}
