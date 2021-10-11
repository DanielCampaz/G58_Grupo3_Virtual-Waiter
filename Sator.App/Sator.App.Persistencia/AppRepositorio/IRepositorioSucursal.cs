using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioSucursal
    {
        IEnumerable<Sucursal> GetAllSucursales();
        Sucursal AddSucursal(Sucursal sucursal);
        Sucursal UpdateSucursal(Sucursal sucursal);
        void DeleteSucursal(int idSucursal);    
        Sucursal GetSucursal(int idSucursal);
    }
}