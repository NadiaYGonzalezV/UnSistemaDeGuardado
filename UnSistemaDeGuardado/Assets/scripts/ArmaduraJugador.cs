using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArmaduraJugador : MonoBehaviour
{
    public int CantidadArmadura;
    public Slider barradearmadura;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barradearmadura.value = CantidadArmadura;
        //if (CantidadArmadura <= 0)
        //{
        //    Destroy(gameObject);
        //}
    }
}
