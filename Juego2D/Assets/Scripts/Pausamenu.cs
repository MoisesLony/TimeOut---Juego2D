using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pausamenu : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;

    private bool juegopausado = false;

    public void Pausa()
    {
        juegopausado = true;
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }

    public void Continuar ()
    {
        juegopausado = false;
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }


    public void Menu1()
    {
        juegopausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }
}
