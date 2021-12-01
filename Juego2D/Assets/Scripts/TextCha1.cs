using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCha1 : MonoBehaviour
{
    public Text miText2;
    void Start()
    {
        
    }
    void Update()
    {
        if (CollectMamager1.texto2 == true)
        {
            miText2.text = "Escapa por el Portal";
        }
        if (Portal1.texto4 == true)
        {
            miText2.text = "¡ESCAPA!";
        }
    }
}
