using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject colli1;
    public GameObject colli2;
    void Start()
    {
        
    }

    void Update()
    {
        if (CollectMamager2.colli == true)
        {
            colli1.SetActive(false);
            colli2.SetActive(true);
        }
    }
}
