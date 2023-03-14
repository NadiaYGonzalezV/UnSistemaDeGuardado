using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModificarVida : MonoBehaviour
{
    public GameObject objetoModificadorV; // referencia al objeto con el script ArmaduraJugador
    public Slider barradevida; // referencia al slider
    public GameObject botonAumentar;
    public GameObject botonReducir;

    public void AumentarVida()
    {
        objetoModificadorV.GetComponent<VidaJugador>().Cantidadvida += 1; // aumenta la cantidad de armadura
        barradevida.value = objetoModificadorV.GetComponent<VidaJugador>().Cantidadvida; // actualiza el valor del slider
    }

    public void ReducirVida()
    {
        objetoModificadorV.GetComponent<VidaJugador>().Cantidadvida -= 1; // reduce la cantidad de armadura
        barradevida.value = objetoModificadorV.GetComponent<VidaJugador>().Cantidadvida; // actualiza el valor del slider
    }
}
