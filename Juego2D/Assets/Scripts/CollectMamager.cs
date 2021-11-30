using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMamager : MonoBehaviour
{
    public static bool abierto = false;
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
            NextLevel.abierto = true;
        }
    }
}
