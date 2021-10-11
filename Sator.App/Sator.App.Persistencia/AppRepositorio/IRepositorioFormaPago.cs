using System;
using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;

namespace Sator.App.Persistencia
{
    public interface IRepositorioFormaPago
    {
        IEnumerable<FormaPago> GetAllFormaPagos();
        FormaPago AddFormaPago(FormaPago formapago);
        FormaPago UpdateFormaPago(FormaPago formapago);
        void DeleteFormaPago(int idFormaPago);    
        FormaPago GetFormaPago(int idFormaPago);
    }
}