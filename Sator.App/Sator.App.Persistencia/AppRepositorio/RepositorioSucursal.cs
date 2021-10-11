using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioSucursal: IRepositorioSucursal
    {
        private readonly AppContext _appContext;

        public RepositorioSucursal(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Sucursal> IRepositorioSucursal.GetAllSucursales()
        {
            return _appContext.Sucursales;
        }
        Sucursal IRepositorioSucursal.AddSucursal(Sucursal sucursal)
        {
            var sucursalAdicionado = _appContext.Sucursales.Add(sucursal);
            _appContext.SaveChanges();
            return sucursalAdicionado.Entity;
        }
        Sucursal IRepositorioSucursal.UpdateSucursal(Sucursal sucursal)
        {
            var SucursalEncontrado = _appContext.Sucursales.FirstOrDefault(p => p.id == sucursal.id);
            if (SucursalEncontrado!= null)
            {
                SucursalEncontrado.descripcion= sucursal.descripcion;
                SucursalEncontrado.direccion= sucursal.direccion;
                SucursalEncontrado.num_fijo= sucursal.num_fijo;
                SucursalEncontrado.num_cel= sucursal.num_cel;
                SucursalEncontrado.estado= sucursal.estado;
                SucursalEncontrado.carta= sucursal.carta;
                _appContext.SaveChanges();
            }
            return SucursalEncontrado;

        }
        void IRepositorioSucursal.DeleteSucursal(int idSucursal)
        {
            var SucursalEncontrado = _appContext.Sucursales.FirstOrDefault(p => p.id == idSucursal);
            if (SucursalEncontrado == null)
                return;
            _appContext.Sucursales.Remove(SucursalEncontrado);
            _appContext.SaveChanges();

        }
        Sucursal IRepositorioSucursal.GetSucursal(int idSucursal)
        {
            return _appContext.Sucursales.FirstOrDefault(p => p.id == idSucursal);
        }

    }
}