using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal1 : MonoBehaviour
{
    public static bool texto4 = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            SceneManager.LoadScene("Level3");
            texto4 = true;
            (CollectMamager1.texto2) = false;
        }
    }
}
