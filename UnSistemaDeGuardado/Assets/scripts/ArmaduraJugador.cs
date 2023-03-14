using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//recuerda agregar esta fucnion para que todo vaya bien.


public class ArmaduraJugador : MonoBehaviour
{
    public int CantidadArmadura; //Cantidad que se podra visualisar y modificar desde el inspector
    public Slider barradearmadura; //lugar donde se asignara el Slider en unity

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barradearmadura.value = CantidadArmadura; //Sirve para conectar el slider con la cantidad que buscas representar en pantalla
                                                  //con este mismo Slider.

        //Este ultimo fragmento de codigo convertido en comentario sirve para que al momento de llegar a cero, tu personaje desaparezca
        //puedes implementarlo en lgun elemento que necesites.

        //if (CantidadArmadura <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }
}
