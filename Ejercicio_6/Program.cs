﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            RepositorioUsuariosLista Repositorio = new RepositorioUsuariosLista();
            OrdenamientoUsuarioPorNombre OrdenamientoNombre = new OrdenamientoUsuarioPorNombre();
            OrdenamientoUsuarioPorCorreo OrdenamientoCorreo = new OrdenamientoUsuarioPorCorreo();
            //   OrdenamientoUsuarioPorNombre Ordenamiento = new OrdenamientoUsuarioPorNombre();

            List<Usuario> m;

            Console.WriteLine("Orden por Codigo"); //ordenamiento por defecto del SortedDictionary
            m = Repositorio.ObtenerTodos().ToList();
            foreach (Usuario a in m)
            {
                Console.WriteLine(a.Codigo + " " + a.Nombre + " " + a.Correo);
            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Orden Por Nombre");
            m = Repositorio.ObtenerOrdenadoPor(OrdenamientoNombre).ToList();
            foreach (Usuario a in m)
            {
                Console.WriteLine(a.Codigo + " " + a.Nombre + " " + a.Correo);
            }
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Orden Por Correo");
            m = Repositorio.ObtenerOrdenadoPor(OrdenamientoCorreo).ToList();
            foreach (Usuario a in m)
            {
                Console.WriteLine(a.Codigo + " " + a.Nombre + " " + a.Correo);
            }

            Console.ReadKey();
        }
    }
}
