using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter: MonoBehaviour
{
    public GameObject Player;
    public Vector3 Offset;

    void Update()
    {
    }


    void OnTriggerEnter(Collider other)
    {
        other.transform.Translate(other.transform.InverseTransformDirection(Offset));
    }
}
