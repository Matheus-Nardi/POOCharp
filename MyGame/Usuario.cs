using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public class Usuario
    {
        public Usuario()
        {
            VidaUsuario = 20;
        }
        public int VidaUsuario { get; set; }

        public int getVida(int vida)
        {
            return vida = VidaUsuario;
        }
    }
}
