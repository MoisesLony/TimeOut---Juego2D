using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMamager1 : MonoBehaviour
{
    public static bool texto2 = false;
    public GameObject portal1;

    private void Update()
    {
        AllObject1();
    }
    public void AllObject1()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Ve al portal");
            portal1.SetActive(true);
            texto2 = true;            
        }
    }
}
