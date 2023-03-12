using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesactivarBoton : MonoBehaviour
{
    //al hacer clic en el boton se desactiva 

    public GameObject optionsMenu;
    public Button optionsButton;

   
    // Start is called before the first frame update
    void Start()
    {
        optionsButton.onClick.AddListener(OpenOptionsMenu);
    }
    private void OpenOptionsMenu()
    {
        optionsMenu.SetActive(true);
        optionsButton.interactable = false;
        //deshabilita el boton despues de 5 segundos o el tiempo que le menciones
        Invoke("ReenableButton", 5f);
    }

    private void ReenableButton()
    {
        optionsButton.interactable = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
