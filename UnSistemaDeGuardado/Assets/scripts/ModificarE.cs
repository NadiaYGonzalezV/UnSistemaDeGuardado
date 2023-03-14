using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModificarE : MonoBehaviour
{
    public GameObject objetoModificadorE; // referencia al objeto con el script ArmaduraJugador
    public Slider barradeEnergia; // referencia al slider
    public GameObject botonAumentar;
    public GameObject botonReducir;

    public void AumentarEnergia()
    {
        objetoModificadorE.GetComponent<EnergíaJugador>().CantidadEnergia += 1; // aumenta la cantidad de armadura
        barradeEnergia.value = objetoModificadorE.GetComponent<EnergíaJugador>().CantidadEnergia; // actualiza el valor del slider
    }

    public void ReducirEnergia()
    {
        objetoModificadorE.GetComponent<EnergíaJugador>().CantidadEnergia -= 1; // reduce la cantidad de armadura
        barradeEnergia.value = objetoModificadorE.GetComponent<EnergíaJugador>().CantidadEnergia; // actualiza el valor del slider
    }
}
