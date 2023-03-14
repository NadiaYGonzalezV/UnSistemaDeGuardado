using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvisoDeGuardadoCarga : MonoBehaviour
{
    public KeyCode tecla1; // La primera tecla que activa el primer sprite
    public KeyCode tecla2; // La segunda tecla que activa el segundo sprite
    public SpriteRenderer spriteRenderer1; // El objeto SpriteRenderer que muestra el primer sprite
    public SpriteRenderer spriteRenderer2; // El objeto SpriteRenderer que muestra el segundo sprite
    public bool spritesVisiblesAlInicio = false; // Indica si los sprites están visibles al inicio

    void Start()
    {
        spriteRenderer1.enabled = spritesVisiblesAlInicio; // Configurar la visibilidad del primer sprite al inicio
        spriteRenderer2.enabled = spritesVisiblesAlInicio; // Configurar la visibilidad del segundo sprite al inicio
    }

    void Update()
    {
        if (Input.GetKeyDown(tecla1)) // Si la primera tecla se presiona
        {
            spriteRenderer1.enabled = true; // Activar el primer sprite
        }

        if (Input.GetKeyUp(tecla1)) // Si la primera tecla se deja de presionar
        {
            spriteRenderer1.enabled = false; // Desactivar el primer sprite
        }

        if (Input.GetKeyDown(tecla2)) // Si la segunda tecla se presiona
        {
            spriteRenderer2.enabled = true; // Activar el segundo sprite
        }

        if (Input.GetKeyUp(tecla2)) // Si la segunda tecla se deja de presionar
        {
            spriteRenderer2.enabled = false; // Desactivar el segundo sprite
        }
    }
}
