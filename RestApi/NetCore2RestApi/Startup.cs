using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using NetCore2BLL;
using NetCore2BLL.BusinessObjects;

namespace NetCore2RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                var facade = new BLLFacade();
                var cust = facade.CustomerService.Create(
                    new CustomerBO() {
                        FirstName="Emir",
                        LastName = "Hazir",
                        Address ="Ankara"
                    });
                facade.CustomerService.Create(
                    new CustomerBO()
                    {
                        FirstName = "Aziz",
                        LastName = "Hazir",
                        Address = "Ankara"
                    });
                //facade.OrderService.Create(
                //new OrderBO()
                //{
                //    DeliveryDate = DateTime.Now.AddMonths(1),
                //    OrderDate = DateTime.Now.AddMonths(-1),
                //    Customer = cust
                //});
                for (int i = 0; i < 10000; i++)
                {
                    facade.OrderService.Create(new OrderBO(){
                        DeliveryDate = DateTime.Now.AddMonths(1),
                        OrderDate = DateTime.Now.AddMonths(-1),
                        CustomerId = cust.Id
                    });
                }
            }

            app.UseMvc();
        }
    }
}
