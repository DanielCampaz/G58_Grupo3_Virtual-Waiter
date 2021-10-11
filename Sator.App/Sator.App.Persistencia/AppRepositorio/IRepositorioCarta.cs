using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioCarta
    {
        IEnumerable<Carta> GetAllCartas();
        Carta AddCarta(Carta carta);
        Carta UpdateCarta(Carta carta);
        void DeleteCarta(int idCarta);    
        Carta GetCarta(int idCarta);
    }
}