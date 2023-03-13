using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergíaJugador : MonoBehaviour
{
    public int CantidadEnergia; //Cantidad que se podra visualisar y modificar desde el inspector
    public Slider barradeEnergia; //lugar donde se asignara el Slider en unity
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barradeEnergia.value = CantidadEnergia; //Sirve para conectar el slider con la cantidad que buscas representar en pantalla
                                                //con este mismo Slider.


        //Este ultimo fragmento de codigo convertido en comentario sirve para que al momento de llegar a cero, tu personaje desaparezca
        //puedes implementarlo en lgun elemento que necesites.

        //if (CantidadEnergia <= 0)
        //{
        //    Destroy(gameObject); Es responsable de destruir el objeto (no se vera en pantalla)
        //}
    }
    
}
