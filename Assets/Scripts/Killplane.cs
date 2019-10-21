using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killplane : MonoBehaviour
{
    public Vector3 ResetPosition;

    void OnTriggerEnter(Collider other)
    {
        other.transform.position = ResetPosition;
    }
}
