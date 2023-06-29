using Entidades;

namespace Test_Generala
{
    [TestClass]
    public class Generala_Test
    {
        [TestMethod]
        public void VerificarIgualdadDado_TrueSiSonIguales()
        {
            bool resultado;
            do
            {
                Dado dadoUno = new Dado();
                Dado dadoDos = new Dado();

                resultado = dadoUno == dadoDos;
            } while (resultado == false);

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarIgualdadJugadorConId_TrueSiSonIguales()
        {
            Jugador jugador = new Jugador(1,"lautaro","garcia");
            int id = 1;

            bool resultado = jugador == id;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarIgualdadJugador_TrueSiSonIguales()
        {
            Jugador jugador = new Jugador(1, "lautaro", "garcia");
            Jugador jugadorDos = new Jugador(1, "lautaro", "garcia");


            bool resultado = jugador == jugadorDos;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarNoEncontrarJugador_JugadorConId0SiNoEncuentra()
        {
            List<Jugador> lista =  new List<Jugador> { new Jugador(1, "lautaro", "garcia") };
            int id = 2;

            Jugador jugadorEncontrado = new Jugador();
            jugadorEncontrado = jugadorEncontrado.Encontrar(lista, id);
            bool resultado = jugadorEncontrado.Id == 0 ? true : false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarGeneracionIdPartida_TrueSiNoEsElPrimerId()
        {
            int id = Partida.GenerarIdAutoincremental();
            bool resultado = id > 1 ? true : false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarEncontrarPartida_TrueSiEncuentraPartida()
        {
            List<Partida> lista = new List<Partida> { new Partida(new Jugador(), new Jugador()) }; // genero una nueva partida con el ultimo id
            int id = Partida.GenerarIdAutoincremental(); // genero el ultimo id

            Partida partidaEncontrada = new Partida();
            partidaEncontrada = partidaEncontrada.Encontrar(lista,id); // si son iguales quiere decir q lo encontro

            bool resultado = partidaEncontrada.IdPartida != 0 ? true : false; // false si no la encontro

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TablasDefault_TrueSiNoEsNUll()
        {
            Tabla tabla = new Tabla();

            Assert.IsNotNull(tabla);
        }

        [TestMethod]
        public void VerificarTipoTirada_TrueSiEsFull_Generala_Escalera_Poker()
        {
            bool resultado;
            do
            {
                Tiradas tirada = new Tiradas();
                Tabla tabla = new Tabla();
                tirada.GenerarTirada();

                resultado = tirada.DetectarTipoTirada(tabla);

            } while (resultado == false);

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarFull_TrueSiEsFull()
        {
            bool resultado;
            int numeroFull;
            do
            {
                Tiradas tirada = new Tiradas();
                Tabla tabla = new Tabla();

                tirada.GenerarTirada();
                tirada.DetectarTipoTirada(tabla);
                numeroFull = tabla.Full;

            } while (numeroFull == 0);
            resultado = numeroFull == 0 ? false : true;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarPoker_TrueSiEsPoker()
        {
            bool resultado;
            int numeroPoker;
            do
            {
                Tiradas tirada = new Tiradas();
                Tabla tabla = new Tabla();

                tirada.GenerarTirada();
                tirada.DetectarTipoTirada(tabla);
                numeroPoker = tabla.Poker;

            } while (numeroPoker == 0);
            resultado = numeroPoker == 0 ? false : true;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarGenerala_TrueSiEsGenerala()
        {
            bool resultado;
            int numeroGenerala;

            do
            {
                Tiradas tirada = new Tiradas();
                Tabla tabla = new Tabla();

                tirada.GenerarTirada();
                tirada.DetectarTipoTirada(tabla);
                numeroGenerala = tabla.Generala;

            } while (numeroGenerala == 0);
            resultado = numeroGenerala == 0 ? false : true;
            

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarEscalera_TrueSiEsEscalera()
        {
            bool resultado;
            int numeroEscalera;

            do
            {
                Tiradas tirada = new Tiradas();
                Tabla tabla = new Tabla();

                tirada.GenerarTirada();
                tirada.DetectarTipoTirada(tabla);
                numeroEscalera = tabla.Escalera;

            } while (numeroEscalera == 0);
            resultado = numeroEscalera == 0 ? false : true;
            

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarCargarDadoSeleccionadoRepetido_TrueSiSeCargoRepetido()
        {
            bool resultado;
            Tiradas tirada;
            do
            {
                tirada = new Tiradas();
                tirada.GenerarTirada();

                tirada.CargarDadoSeleccionado();

            } while (tirada.ListaDadosTirados.Count == 1);

            resultado = tirada.ListaDadosTirados.Count == 2 || tirada.ListaDadosTirados.Count ==3  ? true : false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarCargarDadoSeleccionadoMayor_TrueSiSeCargoMayor()
        {
            bool resultado;
            Tiradas tirada;
            do
            {
                tirada = new Tiradas();
                tirada.GenerarTirada();

                tirada.CargarDadoSeleccionado();

            } while (tirada.ListaDadosTirados.Count != 1);

            resultado = tirada.ListaDadosTirados.Count == 1  ? true : false;

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void VerificarEncuentroDeListaNull_TrueSiEsNull()
        {
            try
            {
                #pragma warning disable   // desactivo warning en las lineas que indique
                Usuario usuario = Usuario.Encontrar(null, "","");
                #pragma warning restore 
                Assert.Fail($"Verificacion fallida, lista no null");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(ValidarExcepcion)); // validar que la excepcion sea del tipo esperado          
            }     
        }

        [TestMethod]
        public void VerificarLeerUsuarioDb_TrueSiSeEncontroLaTabla()
        {
            List<Usuario> lista = UsuarioDao.LeerUsuario();

            bool resultado = lista.Count != 0 ? true: false;

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void VerificarLeerJugadorDb_TrueSiSeEncontroLaTabla()
        {
            try
            {
                List<Jugador> lista = JugadorDao.LeerJugador();

                bool resultado = lista.Count != 0 ? true : false;

                Assert.IsTrue(resultado);
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void VerificarLecturaJson_TrueSiEncontroElArchivo()
        {
            List<Partida> datoGenerico;
            bool resultado;

            datoGenerico= Archivos<List<Partida>>.LecturaJson(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "partidas.json"));            
            resultado = datoGenerico is null  ? false: true;

            Assert.IsTrue(resultado);
        }

    }
}