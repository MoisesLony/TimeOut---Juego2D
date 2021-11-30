using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public static bool abierto = false;
    public GameObject portal;
    private void Update()
    {
        if (abierto == true)
        {
            portal.SetActive(true);
        }
    }
    
}
