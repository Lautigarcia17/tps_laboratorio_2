using Entidades;
using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // AVIONES                       // CA
        Aeronave avionUno = new Aeronave(2, 220, 3, true, true, 370);
        Aeronave avionDos = new Aeronave(2, 190, 2, true, false, 330);
        Aeronave avionTres = new Aeronave(2, 170, 3, false, true, 340);
        Aeronave avionCuatro = new Aeronave(2, 250, 3, false, false, 400);
        List<Aeronave> listaAeronaves = new List<Aeronave>();
        listaAeronaves.Add(avionUno);
        listaAeronaves.Add(avionDos);
        listaAeronaves.Add(avionTres);
        listaAeronaves.Add(avionCuatro);
        Archivos.GuardarJsonAeronave(listaAeronaves);


        // PASAJEROS
        Pasajero pasajeroUno = new Pasajero(3, "Lautaro", "Garcia", 45040166, 19, "Bolso de mano\nValija 1 : 25 KG");
        Pasajero pasajeroDos = new Pasajero(5, "Emanuel", "Garcia", 46045326, 21, "Bolso de mano");
        Pasajero pasajeroTres = new Pasajero(6, "Julio", "Garcia", 32034326, 51, "Bolso de mano\nValija 1 : 21 KG");
        Pasajero pasajeroCuatro = new Pasajero(2, "Esteban", "Hernandez", 42023157, 21, "Bolso de mano\nValija 1 : 20 KG");
        Pasajero pasajeroCinco = new Pasajero(3, "Pedro", "Solari", 40012345, 23, "Valija 1 : 20 KG");
        Pasajero pasajeroSeis = new Pasajero(2, "Julio", "Hauche", 32034336, 48, "Bolso de mano\nValija 1 : 17 KG");

        #region Lista pasajeros uno
        List<Pasajero> listaPasajerosUno = new List<Pasajero>();
        listaPasajerosUno += pasajeroUno;
        listaPasajerosUno += pasajeroDos;
        listaPasajerosUno += pasajeroTres;

        List<Pasajero> listaPasajerosUnoTurista = new List<Pasajero>();
        listaPasajerosUnoTurista += pasajeroUno;
        listaPasajerosUnoTurista += pasajeroTres;

        List<Pasajero> listaPasajerosUnoPremium = new List<Pasajero>();
        listaPasajerosUnoPremium += pasajeroDos;
        #endregion

        #region Lista pasajeros dos
        List<Pasajero> listaPasajerosDos = new List<Pasajero>();
        listaPasajerosDos += pasajeroCuatro;
        listaPasajerosDos += pasajeroSeis;
        listaPasajerosDos += pasajeroDos;

        List<Pasajero> listaPasajerosDosTurista = new List<Pasajero>();
        listaPasajerosDosTurista += pasajeroCuatro;
        listaPasajerosDosTurista += pasajeroSeis;

        List<Pasajero> listaPasajerosDosPremium = new List<Pasajero>();
        listaPasajerosDosPremium += pasajeroDos;
        #endregion


        #region Lista pasajeros tres
        List<Pasajero> listaPasajerosTres = new List<Pasajero>();
        listaPasajerosTres += pasajeroTres;
        listaPasajerosTres += pasajeroCinco;

        List<Pasajero> listaPasajerosTresTurista = new List<Pasajero>();
        listaPasajerosTresTurista += pasajeroTres;
        listaPasajerosTresTurista += pasajeroCinco;
        #endregion



                                    // estado vuelo                     origen       destino                       fecha                  avion     cap cat  ct   cp    duracionVuelo        //peso
        Vuelo vueloUno = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Santa Rosa", "Bariloche", new DateTime(2023, 8, 19, 23, 45, 00), avionUno, 44, 176, 100, 135, new TimeSpan(2, 40, 00), 41, listaPasajerosTres, listaPasajerosTresTurista, new List<Pasajero>());
        Vuelo vueloDos = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Tucuman", "Jujuy", new DateTime(2023, 12, 9, 12, 24, 00), avionDos, 38, 152, 100, 135, new TimeSpan(2, 36, 00), 46, listaPasajerosUno, listaPasajerosUnoTurista, listaPasajerosUnoPremium);
        Vuelo vueloTres = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Tucuman", "Trelew", new DateTime(2023, 8, 9, 10, 22, 00), avionTres, 34, 136, 50, 67.5f, new TimeSpan(1, 30, 00), 37, listaPasajerosDos, listaPasajerosDosTurista, listaPasajerosDosPremium);
        Vuelo vueloCuatro = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Buenos Aires", "Recife", new DateTime(2022, 6, 9, 10, 30, 00), avionCuatro, 50,200, 800, 1080, new TimeSpan(8, 42, 00), 41, listaPasajerosTres, listaPasajerosTresTurista, new List<Pasajero>());
        Vuelo vueloCinco = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Buenos Aires", "Miami", new DateTime(2024, 2, 1, 20, 00, 00), avionCuatro, 50, 200, 1000, 1350, new TimeSpan(10, 20, 00), 46, listaPasajerosUno, listaPasajerosUnoTurista, listaPasajerosUnoPremium);
        Vuelo vueloSeis = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Buenos Aires", "Recife", new DateTime(2025, 1, 1, 1, 00, 00), avionDos, 38, 152, 1100, 1485, new TimeSpan(11, 21, 00), 37, listaPasajerosDos, listaPasajerosDosTurista, listaPasajerosDosPremium);
        Vuelo vueloSiete = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Buenos Aires", "Roma", new DateTime(2023, 11, 4, 3, 30, 00), avionTres, 34, 136, 1200, 1620, new TimeSpan(12, 55, 00), 41, listaPasajerosTres, listaPasajerosTresTurista, new List<Pasajero>());
        Vuelo vueloOcho = new Vuelo(ETipoEstadoVuelo.Proximo.ToString(), "Puerto Madryn", "Cordoba", new DateTime(2024, 10, 10, 5, 40, 00), avionUno, 44, 176, 100, 135, new TimeSpan(00, 58, 00), 46, listaPasajerosUno, listaPasajerosUnoTurista, listaPasajerosUnoPremium);

        List<Vuelo> listaVuelos = new List<Vuelo>(); // guardar los vuelos
        listaVuelos.Add(vueloUno);
        listaVuelos.Add(vueloDos);
        listaVuelos.Add(vueloTres);
        listaVuelos.Add(vueloCuatro);
        listaVuelos.Add(vueloCinco);
        listaVuelos.Add(vueloSeis);
        listaVuelos.Add(vueloSiete);
        listaVuelos.Add(vueloOcho);

        Archivos.GuardarXmlVuelos(listaVuelos);

        listaPasajerosUno.Clear(); // guardar los pasajeros
        listaPasajerosUno += pasajeroUno;
        listaPasajerosUno += pasajeroDos;
        listaPasajerosUno += pasajeroTres;
        listaPasajerosUno += pasajeroCuatro;
        listaPasajerosUno += pasajeroCinco;
        listaPasajerosUno += pasajeroSeis;
        Archivos.GuardarXmlPasajeros(listaPasajerosUno);


    }




}