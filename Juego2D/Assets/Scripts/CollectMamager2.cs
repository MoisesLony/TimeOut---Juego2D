using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectMamager2 : MonoBehaviour
{
    public static bool colli = false;
    

    private void Update()
    {
        AllObject1();
    }
    public void AllObject1()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("Ve al portal");
            colli = true;
        }
    }
}
