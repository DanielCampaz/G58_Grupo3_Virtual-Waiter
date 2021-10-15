using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Presentacion
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
            services.AddRazorPages();
            services.AddScoped<IRepositorioCarta,RepositorioCarta>();
            services.AddScoped<IRepositorioFormaPago,RepositorioFormaPago>();
            services.AddScoped<IRepositorioGenero, RepositorioGenero>();
            services.AddScoped<IRepositorioIngrediente, RepositorioIngrediente>();
            services.AddScoped<IRepositorioOrden, RepositorioOrden>();
            services.AddScoped<IRepositorioPedido, RepositorioPedido>();
            services.AddScoped<IRepositorioPersona, RepositorioPersona>();
            services.AddScoped<IRepositorioProducto, RepositorioProducto>();
            services.AddScoped<IRepositorioProductoTamano, RepositorioProductoTamano>();
            services.AddScoped<IRepositorioSucursal, RepositorioSucursal>();
            services.AddScoped<IRepositorioTamano, RepositorioTamano>();
            services.AddScoped<IRepositorioTipoId, RepositorioTipoId>();
            services.AddScoped<IRepositorioTipoPedido, RepositorioTipoPedido>();
            services.AddScoped<IRepositorioTipoProducto, RepositorioTipoProducto>();
            services.AddSingleton<Sator.App.Persistencia.AppContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
