using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
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
