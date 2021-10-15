using System;
using Sator.App.Dominio;
using Sator.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace Sator.App.Consola
{
    class Program
    {
        private static IRepositorioGenero _repoGenero = new RepositorioGenero (new Persistencia.AppContext());
        private static IRepositorioIngrediente _repoIngrediente = new RepositorioIngrediente (new Persistencia.AppContext());
        
        private static IEnumerable<Genero> generos { get; set; }
        private static IEnumerable<Ingrediente> ingredientes { get; set; }

        
        private static IRepositorioProducto _repoProducto = new RepositorioProducto (new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ElimProducto(1);
            ElimIngrediente(1);
            ElimIngrediente(2);
        }
        private static void AddGenero(){
            var genero = new Genero
            {               
                abreviatura = "H",
                descripcion = "Hombre"
            };
            _repoGenero.AddGenero(genero);
        }
        private static void ListGenero(){
            generos = _repoGenero.GetAllGeneros();
            foreach (var item in generos)
            {
                Console.WriteLine(item.abreviatura);
                Console.WriteLine(item.descripcion);
            }
        }
        private static void ListIngrediente(){
            ingredientes = _repoIngrediente.GetAllIngredientes();
            if (ingredientes != null)
            {
                foreach (var item in ingredientes)
                {
                    Console.WriteLine(item.descripcion);
                    Console.WriteLine(item.cantidad);
                }    
            }else{
                Console.WriteLine("No hay Ingredientes");
            }
            
        }
        private static Genero traGenero(){
            Genero generoEn = _repoGenero.GetGenero(1);
            Console.WriteLine(generoEn);
            return generoEn;
        }
        private static void ElimiGenero(Genero genero){
            _repoGenero.DeleteGenero(genero.id);
        }
        private static void ElimProducto(int idProducto)
        {
            _repoProducto.DeleteProducto(idProducto);
        }
        private static void ElimIngrediente(int idIngre)
        {
            _repoIngrediente.DeleteIngrediente(idIngre);
        }
    }
}