using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMamager : MonoBehaviour
{
    public static bool texto,texto2 = false;
    public GameObject portal;

    private void Update()
    {
        AllObject();
    }
    public void AllObject()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Ve al portal");
            portal.SetActive(true);
            texto = true;            
        }
    }
}
