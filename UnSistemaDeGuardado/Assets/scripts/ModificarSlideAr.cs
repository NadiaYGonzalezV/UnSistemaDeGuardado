using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ModificarSlideAr : MonoBehaviour
{
    public GameObject objetoModificadorA; // referencia al objeto con el script ArmaduraJugador
    public Slider barradearmadura; // referencia al slider
    public GameObject botonAumentar;
    public GameObject botonReducir;

    public void AumentarArmadura()
    {
        objetoModificadorA.GetComponent<ArmaduraJugador>().CantidadArmadura += 1; // aumenta la cantidad de armadura
        barradearmadura.value = objetoModificadorA.GetComponent<ArmaduraJugador>().CantidadArmadura; // actualiza el valor del slider
    }

    public void ReducirArmadura()
    {
        objetoModificadorA.GetComponent<ArmaduraJugador>().CantidadArmadura -= 1; // reduce la cantidad de armadura
        barradearmadura.value = objetoModificadorA.GetComponent<ArmaduraJugador>().CantidadArmadura; // actualiza el valor del slider
    }
}
