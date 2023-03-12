using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueadorGuardado : MonoBehaviour
{
    public KeyCode teclaBloqueada; // Tecla que se bloqueará
    public GameObject objetoDesbloqueador; // Objeto que desbloqueará la tecla

    private bool teclaDesbloqueada = false; // Variable que indica si la tecla está desbloqueada

    private void Update()
    {
        if (teclaDesbloqueada) // Si la tecla está desbloqueada
        {
            if (Input.GetKeyDown(teclaBloqueada)) // Si se presiona la tecla bloqueada
            {
                teclaDesbloqueada = false; // Volver a bloquear la tecla
            }
        }
        else // Si la tecla está bloqueada
        {
            if (Input.GetKeyDown(teclaBloqueada) && objetoDesbloqueador != null && objetoDesbloqueador.activeSelf) // Si se presiona la tecla bloqueada y el objeto desbloqueador está activo
            {
                teclaDesbloqueada = true; // Desbloquear la tecla
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == objetoDesbloqueador) // Si se colisiona con el objeto desbloqueador
        {
            objetoDesbloqueador.SetActive(false); // Desactivar el objeto desbloqueador
            teclaDesbloqueada = true; // Desbloquear la tecla
        }
    }
    //no funciona
}
