using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergíaJugador : MonoBehaviour
{
    public int CantidadEnergia;
    public Slider barradeEnergia;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barradeEnergia.value = CantidadEnergia;
        //if (CantidadEnergia <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }
}
