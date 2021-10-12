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
        
        private static IEnumerable<Genero> generos { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddGenero();
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
        private static Genero traGenero(){
            Genero generoEn = _repoGenero.GetGenero(1);
            Console.WriteLine(generoEn);
            return generoEn;
        }
        private static void ElimiGenero(Genero genero){
            _repoGenero.DeleteGenero(genero.id);
        }
    }
}