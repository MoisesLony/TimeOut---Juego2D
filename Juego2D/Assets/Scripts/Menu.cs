using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Juego()
    {
        SceneManager.LoadScene("Level1");

    }

    public void Niveles()
    {
        SceneManager.LoadScene("Niveles");
    }
    public void Salir()
    {
        Application.Quit();
    }

    public void Nivel1()

    {
        SceneManager.LoadScene("Level1");

    }

    public void Nivel2()

    {
        SceneManager.LoadScene("Level2");

    }

    public void Regresar()

    {
        SceneManager.LoadScene("Menu");

    }


}

