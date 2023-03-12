using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueadorGuardado : MonoBehaviour
{
    public KeyCode teclaBloqueada; // Tecla que se bloquear�
    public GameObject objetoDesbloqueador; // Objeto que desbloquear� la tecla

    private bool teclaDesbloqueada = false; // Variable que indica si la tecla est� desbloqueada

    private void Update()
    {
        if (teclaDesbloqueada) // Si la tecla est� desbloqueada
        {
            if (Input.GetKeyDown(teclaBloqueada)) // Si se presiona la tecla bloqueada
            {
                teclaDesbloqueada = false; // Volver a bloquear la tecla
            }
        }
        else // Si la tecla est� bloqueada
        {
            if (Input.GetKeyDown(teclaBloqueada) && objetoDesbloqueador != null && objetoDesbloqueador.activeSelf) // Si se presiona la tecla bloqueada y el objeto desbloqueador est� activo
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
