using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioTipoPedido
    {
        IEnumerable<TipoPedido> GetAllTipoPedidos();
        TipoPedido AddTipoPedido(TipoPedido tipoPedido);
        TipoPedido UpdateTipoPedido(TipoPedido tipoPedido);
        void DeleteTipoPedido(int idTipoPedido);    
        TipoPedido GetTipoPedido(int idTipoPedido);
    }
}
