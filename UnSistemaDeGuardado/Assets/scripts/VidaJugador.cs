using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public int Cantidadvida;
    public Slider barradevida;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    //El update lee constantemente los datos escritos 
    void Update()
    {
        barradevida.value = Cantidadvida;
        if ( Cantidadvida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
