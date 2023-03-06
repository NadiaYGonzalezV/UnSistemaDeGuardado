using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2D;

    [Header("Movimiento")]

    private float movimientoHorizontal = 0f;

    [SerializeField] private float velocidadDemoviemitno;
    [SerializeField] private float suavizadoDeMovimiento;

    private Vector3 velocidad = Vector3.zero;

    private bool vistafrente = true;

    [Header("Salto")]
    [SerializeField] private float fuerzadesalto;
    [SerializeField] private LayerMask EsSuelo;
    [SerializeField] private Transform cotroladordeSuelo;
    [SerializeField] private Vector3 dimensiondeCaja;
    [SerializeField] private bool enSuelo;
    private bool salto = false; 


    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movimientoHorizontal = Input.GetAxisRaw("Horizontal") * velocidadDemoviemitno;

        //salto
        if (Input.GetButtonDown("Jump"))
        {
            salto = true;
        }
    }

    private void FixedUpdate()
    {
        //salto
       enSuelo = Physics2D.OverlapBox(cotroladordeSuelo.position, dimensiondeCaja, 0f, EsSuelo);

        //mover en base al tiempo y por momentos mas rapido y lento y a la misma velocidad 
        Mover(movimientoHorizontal * Time.fixedDeltaTime,salto);

        salto = false;

    }

    private void Mover (float mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocidadObjetivo, ref velocidad, suavizadoDeMovimiento);

        if  (mover > 0 && !vistafrente)
        {
            Girar();
        }
        else if (mover < 0 && vistafrente)
        {
            Girar();
        }

        if(enSuelo && saltar)
        {
            enSuelo = false;
            rb2D.AddForce(new Vector2(0f, fuerzadesalto));
        }
    }
    private void Girar()
    {
        vistafrente = !vistafrente;
        Vector3 escala = transform.localScale;
        escala.x *= 1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {
            Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(cotroladordeSuelo.position, dimensiondeCaja);
    }


}
