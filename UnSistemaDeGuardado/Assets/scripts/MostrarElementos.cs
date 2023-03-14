using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarElementos : MonoBehaviour
{
    public TMP_Text textoPosicion; // El objeto Text Mesh Pro que muestra la posición del personaje

    void Update()
    {
        textoPosicion.text = "Posicion: (" + transform.position.x.ToString("F2") + ", " + transform.position.y.ToString("F2") + ")"; // Actualizar el texto con las coordenadas del personaje
    }
}
