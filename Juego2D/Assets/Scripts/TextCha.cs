using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCha : MonoBehaviour
{
    public Text miText;
    void Start()
    {
        
    }

    void Update()
    {
        if (CollectMamager.texto == true)
        {
            miText.text = "Escapa por el Portal";
        }
        if (Portal.texto1 == true)
        {
            miText.text = "¡Recolecta los items para avanzar de nivel!";
        }
    }
}
