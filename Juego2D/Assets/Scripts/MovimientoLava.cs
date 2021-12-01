using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoLava : MonoBehaviour
{
    public Transform target;
    public float speed;
    void Update()
    {
        float steap = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target.position,steap);
    }
}
