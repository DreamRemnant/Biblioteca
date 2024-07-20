using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Usuarios
    {
        private static List<Persona> Personas = new List<Persona>();

        public Persona ObtenerPorUsername (string username)
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

        public Persona ObtenerPorNombre(string nombre)
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

        public List<Persona> ObtenerLectores()
        {
            List<Persona> lectores = new List<Persona>();
            foreach(Persona usuario in Personas)
            {
                if (usuario is Lector)
                {
                    lectores.Add(usuario);
                }
            }

            return lectores;
        }
        public List<Persona> ObtenerBibliotecarios()
        {
            List<Persona> lectores = new List<Persona>();
            foreach(Persona usuario in Personas)
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
