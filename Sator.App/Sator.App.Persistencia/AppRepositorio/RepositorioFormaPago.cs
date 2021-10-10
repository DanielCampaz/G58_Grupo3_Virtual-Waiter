using System.Collections.Generic;
using System.Linq;
using Sator.App.Dominio;
using Sator.App.Persistencia.AppRepositorio;

namespace Sator.App.Persistencia.AppRepositorio
{
    public class RepositorioFormaPago: IRepositorioFormaPago
    {
        private readonly AppContext _appContext;

        public RepositorioFormaPago(AppContext appContext)
        {
            _appContext = appContext;
        }
        IEnumerable<FormaPago> IRepositorioFormaPago.GetAllFormaPagos()
        {
            return _appContext.FormaPagos;
        }
        FormaPago IRepositorioFormaPago.AddFormaPago(FormaPago formapago)
        {
            var formapagoAdicionado = _appContext.FormaPagos.Add(formapago);
            _appContext.SaveChanges();
            return formapagoAdicionado.Entity;
        }
        FormaPago IRepositorioFormaPago.UpdateFormaPago(FormaPago formapago)
        {
            var FormaPagoEncontrado = _appContext.FormaPagos.FirstOrDefault(p => p.id == formapago.id);
            if (FormaPagoEncontrado!= null)
            {
                FormaPagoEncontrado.descripcion= formapago.descripcion;
                _appContext.SaveChanges();
            }
            return FormaPagoEncontrado;
        }
        void IRepositorioFormaPago.DeleteFormaPago(int idFormaPago)
        {
            var FormaPagoEncontrado = _appContext.FormaPagos.FirstOrDefault(p => p.id == idFormaPago);
            if (FormaPagoEncontrado == null)
                return;
            _appContext.FormaPagos.Remove(FormaPagoEncontrado);
            _appContext.SaveChanges();
        }
        FormaPago IRepositorioFormaPago.GetFormaPago(int idFormaPago)
        {
            return _appContext.FormaPagos.FirstOrDefault(p => p.id == idFormaPago);
        }
    }
}