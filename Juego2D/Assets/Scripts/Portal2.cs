using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Portal2 : MonoBehaviour
{
    public static bool texto4 = false;
    public GameObject canvas1;
    public GameObject canvas2;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            canvas1.SetActive(false);
            canvas2.SetActive(true);
        }
    }
}
