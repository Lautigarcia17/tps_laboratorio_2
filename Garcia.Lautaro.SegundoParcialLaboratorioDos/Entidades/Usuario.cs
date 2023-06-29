using System.Text;

namespace Entidades
{
    public class Usuario : IEncontrarDato<List<Usuario>,Usuario>
    {
        private int id;
        private string nombreUsuario;
        private string contrasenia;

        public Usuario() 
        {
            this.id = 0;
            this.nombreUsuario = string.Empty;
            this.contrasenia = string.Empty;
        }

        public Usuario(int id, string nombreUsuario, string contrasenia) : this()
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
        }

        public int Id 
        { 
            get => id; 
        }
        public string NombreUsuario 
        { 
            get => this.nombreUsuario; 
        }
        public string Contrasenia 
        { 
            get => this.contrasenia; 
        }

        /// <summary>
        /// Muestra todos los atributos de la clase Usuario, y lo retorna en un string
        /// </summary>
        /// <returns>string con todos los datos</returns>
        private string MostrarUsuario()
        {
            StringBuilder datos = new StringBuilder();

            datos.AppendLine($" ID: {this.id}");
            datos.AppendLine($" USUARIO: {this.nombreUsuario}");
            datos.AppendLine($" CONTRASEÑA: {this.contrasenia}");
            return datos.ToString();    
        }
        /// <summary>
        /// LLama al metodo MostrarUsuario(), que contiene todos los atributos de la clase y lo retorna en formato string
        /// </summary>
        /// <returns>String de datos</returns>
        public override string ToString()
        {
            return this.MostrarUsuario(); 
        }

        /// <summary>
        /// Busca en una lista de usuarios, un Usuario que coincida con el nombre y contrasenia enviados, comparandolos por los atributos nombreUsuario y contrasenia.
        /// En caso de que lo encuentre retorna el Usuario solicitado, sino un Usuario por default.
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="nombre"></param>
        /// <param name="contrasenia"></param>
        /// <returns>Usuario del id enviado o un default</returns>
        public static Usuario Encontrar(List<Usuario> lista, string nombre, string contrasenia)
        {
            Usuario usuario = new Usuario();

            if (lista is not null)
            {
                foreach (Usuario item in lista)
                {
                    if (item.nombreUsuario == nombre && item.contrasenia == contrasenia)
                    {
                        usuario = item;
                        break;
                    }
                }
            }
            else
            {
                throw new ValidarExcepcion();
            }
            return usuario;
        }

        /// <summary>
        /// Busca en una lista de usuarios, un Usuario con el id mandado por parametros, cuando compara el atributo id del Usuario con el id por parametro , retorna el Usuario, 
        /// si no se encuentra retorna un Usuario por default
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="id"></param>
        /// <returns>Usuario del id enviado o un default</returns>
        public Usuario Encontrar(List<Usuario> lista, int id)
        {
            Usuario usuario = new Usuario();

            foreach (Usuario item in lista)
            {
                if (item.id == id)
                {
                    usuario = item;
                    break;
                }
            }
            return usuario;
        }



    }
}