using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioTipoPedido: IRepositorioTipoPedido
    {
        private readonly AppContext _appContext;

        public RepositorioTipoPedido(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<TipoPedido> IRepositorioTipoPedido.GetAllTipoPedidos()
        {
            return _appContext.TipoPedidos;
        }
        TipoPedido IRepositorioTipoPedido.AddTipoPedido(TipoPedido tipoPedido)
        {
            var tipoPedidoAdicionado = _appContext.TipoPedidos.Add(tipoPedido);
            _appContext.SaveChanges();
            return tipoPedidoAdicionado.Entity;
        }
        TipoPedido IRepositorioTipoPedido.UpdateTipoPedido(TipoPedido tipoPedido)
        {
            var tipoPedidoEncontrado = _appContext.TipoPedidos.FirstOrDefault(p => p.id == tipoPedido.id);
            if (tipoPedidoEncontrado!= null)
            {
                tipoPedidoEncontrado.descripcion= tipoPedido.descripcion;
                 _appContext.SaveChanges();
            }
            return tipoPedidoEncontrado;
        }
        void IRepositorioTipoPedido.DeleteTipoPedido(int idTipoPedido)
        {
            var tipoPedidoEncontrado= _appContext.TipoPedidos.FirstOrDefault(p => p.id == idTipoPedido);
            if (tipoPedidoEncontrado == null)
                return;
            _appContext.TipoPedidos.Remove(tipoPedidoEncontrado);
            _appContext.SaveChanges();
        }
        TipoPedido IRepositorioTipoPedido.GetTipoPedido(int idTipoPedido)
        {
            return _appContext.TipoPedidos.FirstOrDefault(p => p.id == idTipoPedido);
        }

    }
}
