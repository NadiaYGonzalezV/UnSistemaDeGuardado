using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; //Recuerda agregar esta funcion para que tu sistema funcione bien.

public class ControladorDatos : MonoBehaviour
{
    public GameObject jugador; //objeto a quien le guardaran los datos
    public string archivosdeGuardado;
    //Nombre del script de "datosguardados"
    public DatosGuardados datosjuego = new DatosGuardados();

    private void Awake()
    {
        archivosdeGuardado = Application.dataPath + "/datosJuego.json"; //como se guardaran los datos
        jugador = GameObject.FindGameObjectWithTag("player");
        //ayudara a que cuando inicie el juego nuestro personaje aparecera en la ultima posicion guardada 
        CargarDatos();
    }

    private void Update()

    //las teclas que haran la funcion de guardado y carga
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            CargarDatos();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GuardarDatos();
        }

    }

    //Los datos que seran guardados
    private void CargarDatos()
    {
        if (File.Exists(archivosdeGuardado))
        {
            string contenido = File.ReadAllText(archivosdeGuardado);
            datosjuego = JsonUtility.FromJson <DatosGuardados>(contenido);

            Debug.Log("Posicion Jugador: " + datosjuego.posicion);

            //ayuda a actualizar la posicion de nuestro jugador cuando le damos la tecla C (de cargar)
            jugador.transform.position = datosjuego.posicion;

            //Asi mismo, los siguientes parrafos cargaran los datos de vida, armadura y energia
            jugador.GetComponent<VidaJugador>().Cantidadvida = datosjuego.Vida;
            jugador.GetComponent<ArmaduraJugador>().CantidadArmadura = datosjuego.Armadura;
            jugador.GetComponent<EnergíaJugador>().CantidadEnergia = datosjuego.Energia;
        }
        else
        {
            //en el caso de no haber guardado nada aparecera el siguiente mensaje en la consola

            Debug.Log("El archivo no existe");

            
        }
    }

    //Aqui sera la forma en la que se guardaran los datos de todos nuestros elementos
    private void GuardarDatos()
    {
        DatosGuardados nuevosDatos = new DatosGuardados()
        {
            posicion = jugador.transform.position,
            Vida = jugador.GetComponent<VidaJugador>().Cantidadvida,
            Armadura = jugador.GetComponent<ArmaduraJugador>().CantidadArmadura,
            Energia = jugador.GetComponent<EnergíaJugador>().CantidadEnergia,

        };
        string cadenaJSON = JsonUtility.ToJson(nuevosDatos);
        File.WriteAllText(archivosdeGuardado, cadenaJSON);
        Debug.Log("Archivo Guardado"); //Mensaje que aparecera al momento de guardar los datos y haberlos modificado
    }

    //Este script nos ayuda a que cada vez que guardemos nuestro personaje reparecera en dicha posicion donde guardamos
    //pues al momento de cargar esa posicion se respetara y nuestro personaje siemrpe reaparecera en los puntos donde guardemos 
}
