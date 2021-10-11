using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia;

namespace Sator.App.Persistencia
{
    public class RepositorioPedido: IRepositorioPedido
    {
        private readonly AppContext _appContext;

        public RepositorioPedido(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Pedido> IRepositorioPedido.GetAllPedidos()
        {
            return _appContext.Pedidos;
        }
        Pedido IRepositorioPedido.AddPedido(Pedido pedido)
        {
            var pedidoAdicionado = _appContext.Pedidos.Add(pedido);
            _appContext.SaveChanges();
            return pedidoAdicionado.Entity;
        }
        Pedido IRepositorioPedido.UpdatePedido(Pedido pedido)
        {
            var pedidoEncontrado = _appContext.Pedidos.FirstOrDefault(p => p.id == pedido.id);
            if (pedidoEncontrado!= null)
            {
               pedidoEncontrado.orden= pedido.orden;
                pedidoEncontrado.cliente= pedido.cliente;
                pedidoEncontrado.fecha= pedido.fecha;
                pedidoEncontrado.horapedido= pedido.horapedido;
                pedidoEncontrado.horaentrega= pedido.horaentrega;
                pedidoEncontrado.tipo= pedido.tipo;
                pedidoEncontrado.empleado= pedido.empleado;
                pedidoEncontrado.formapago= pedido.formapago;
                 _appContext.SaveChanges();
            }
            return pedidoEncontrado;
        }
        void IRepositorioPedido.DeletePedido(int idPedido)
        {
            var pedidoEncontrado= _appContext.Pedidos.FirstOrDefault(p => p.id == idPedido);
            if (pedidoEncontrado == null)
                return;
            _appContext.Pedidos.Remove(pedidoEncontrado);
            _appContext.SaveChanges();
        }
        Pedido IRepositorioPedido.GetPedido(int idPedido)
        {
            return _appContext.Pedidos.FirstOrDefault(p => p.id == idPedido);
        }

    }
}
