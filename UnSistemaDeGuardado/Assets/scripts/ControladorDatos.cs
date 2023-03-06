using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ControladorDatos : MonoBehaviour
{
    public GameObject jugador;
    public string archivosdeGuardado;
    //Nombre del script de "datosguardados"
    public DatosGuardados datosjuego = new DatosGuardados();

    private void Awake()
    {
        archivosdeGuardado = Application.dataPath + "/datosJuego.json";
        jugador = GameObject.FindGameObjectWithTag("player");
        //ayudara a que cuando inicie el juego nuestro personaje aparecera en l ultima posicion guardada 
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
    private void CargarDatos()
    {
        if (File.Exists(archivosdeGuardado))
        {
            string contenido = File.ReadAllText(archivosdeGuardado);
            datosjuego = JsonUtility.FromJson <DatosGuardados>(contenido);

            Debug.Log("Posicion Jugador: " + datosjuego.posicion);
            //ayuda a actualizar la posicion de nuestro jugador cuando le damos la tecla C (de cargar)
            jugador.transform.position = datosjuego.posicion;
        }
        else
        {
            Debug.Log("El archivo no existe");

            
        }
    }
    private void GuardarDatos()
    {
        DatosGuardados nuevosDatos = new DatosGuardados()
        {
            posicion = jugador.transform.position
        };
        string cadenaJSON = JsonUtility.ToJson(nuevosDatos);
        File.WriteAllText(archivosdeGuardado, cadenaJSON);
        Debug.Log("Archivo Guardado");
    }

    //Este script nos ayuda a que cada vez que guardemos nuestro personaje reparecera en dicha posicion donde guardamos
    //pues al momento de cargar esa posicion se respetara y nuestro personaje siemrpe reaparecera en los puntos donde guardemos 
}
