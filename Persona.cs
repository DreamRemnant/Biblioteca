using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal abstract class Persona
    {
        public string Nombre { get; set; }
        public Guid ID { get; set; } = Guid.NewGuid();
        public string Username { get; set; }
        public string Contraseña { get; set; }

        public void Validar(string contraseña)
        {
            if (contraseña == this.Contraseña)
            {
                Menu();
            }

            return;
        }

        public abstract void Menu();
        private  void RegistrarUsuario()
        {
            
        }
    }
}
