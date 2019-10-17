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
        //other.GetComponent<PlayerTranslater>().Teleport(other.transform.position + Offset);
        Debug.Log(other.transform.position);
        Debug.Log("Teleported!");
    }
}
