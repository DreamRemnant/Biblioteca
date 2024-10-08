﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal static class Usuarios
    {
        private static List<Persona> Personas = new List<Persona>();

        public static Persona ObtenerPorUsername (string username)
        {
            foreach (Persona usuario in Personas)
            {
                if (usuario.Username == username)
                {
                    return usuario;
                }
            }

            throw new Exception("No se encontró un usuario con ese Username.");
        }

        public static Persona ObtenerPorNombre(string nombre)
        {
            foreach (Persona usuario in Personas)
            {
                if (usuario.Nombre == nombre)
                {
                    return usuario;
                }
            }

            throw new Exception("No se encontró un usuario con ese Username.");
        }

        public static void RegistrarUsuario(Persona persona)
        {
            Personas.Add(persona);
            Console.WriteLine("¡Usuario registrado correctamente!");
        }

        public static void EliminarUsuario(String username)
        {
            Personas.Remove(ObtenerPorUsername(username));
        }

        public static List<Persona> ObtenerLectores()
        {
            List<Persona> lectores = new List<Persona>();
            foreach (Persona usuario in Personas)
            {
                if (usuario is Lector)
                {
                    lectores.Add(usuario);
                }
            }

            return lectores;
        }
        public static List<Persona> ObtenerBibliotecarios()
        {
            List<Persona> lectores = new List<Persona>();
            foreach (Persona usuario in Personas)
            {
                if (usuario is Bibliotecario)
                {
                    lectores.Add(usuario);
                }
            }

            return lectores;
        }
    }
}
