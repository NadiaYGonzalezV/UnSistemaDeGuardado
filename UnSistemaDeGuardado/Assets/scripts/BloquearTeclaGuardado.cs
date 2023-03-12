using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquearTeclaGuardado : MonoBehaviour
{
    public KeyCode teclaBloqueada; //tecla que sera bloqueada
    public GameObject objetodesbloqueo; // objeto responsable de desbloquear la tecla

    private bool teclPresionada = false; //variable responsable de indicr si la tecla esta desbloqueada
   
    // Update is called once per frame
    void Update()
    {
        if(teclPresionada) //si la tecla esta desbloqueada 
        {
            if (Input.GetKeyDown(teclaBloqueada))
            {
                teclPresionada = false; //volver a bloquear la tecla
            }
        }
        else
        {     // Si se presiona la tecla bloqueada y el objeto desbloqueador está activo
                if (Input.GetKeyDown(teclaBloqueada) && objetodesbloqueo != null && objetodesbloqueo.activeSelf)
            {
                teclPresionada = true; // Desbloquear la tecla
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.gameObject == objetodesbloqueo)// Si se colisiona con el objeto que desbloquea
        {
            objetodesbloqueo.SetActive(false); // Desactiva
        }
    }
}//no funciona
