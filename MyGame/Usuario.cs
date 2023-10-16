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
            UsuVivo = true;
        }
        public int VidaUsuario { get; set; }
        public bool UsuVivo { get; set; }

        public int getVida()
        {
            return VidaUsuario;
        }
    }
}
