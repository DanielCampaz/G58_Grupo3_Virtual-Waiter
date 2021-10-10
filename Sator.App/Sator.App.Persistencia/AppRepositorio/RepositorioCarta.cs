using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioCarta: IRepositorioCarta
    {
        private readonly AppContext _appContext;

        public RepositorioCarta(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<Carta> IRepositorioCarta.GetAllCartas()
        {
            return _appContext.Cartas;
        }
        Carta IRepositorioCarta.AddCarta(Carta carta)
        {
            var cartaAdicionado = _appContext.Cartas.Add(carta);
            _appContext.SaveChanges();
            return cartaAdicionado.Entity;
        }
        Carta IRepositorioCarta.UpdateCarta(Carta carta)
        {
            var CartaEncontrado = _appContext.Cartas.FirstOrDefault(p => p.id == carta.id);
            if (CartaEncontrado!= null)
            {
                CartaEncontrado.productos= carta.productos;
                CartaEncontrado.estado= carta.estado;
                _appContext.SaveChanges();
            }
            return CartaEncontrado;
        }
        void IRepositorioCarta.DeleteCarta(int idCarta)
        {
            var CartaEncontrado = _appContext.Cartas.FirstOrDefault(p => p.id == idCarta);
            if (CartaEncontrado == null)
                return;
            _appContext.Cartas.Remove(CartaEncontrado);
            _appContext.SaveChanges();
        }
        Carta IRepositorioCarta.GetCarta(int idCarta)
        {
            return _appContext.Cartas.FirstOrDefault(p => p.id == idCarta);
        }
    }
}