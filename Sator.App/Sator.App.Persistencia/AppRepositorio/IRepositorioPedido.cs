using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public interface IRepositorioPedido
    {
        IEnumerable<Pedido> GetAllPedidos();
        Pedido AddPedido(Pedido pedido);
        Pedido UpdatePedido(Pedido pedido);
        void DeletePedido(int idPedido);    
        Pedido GetPedido(int idPedido);
    }
}
