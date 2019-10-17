using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorController : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Offset;

    void Update()
    {
    }


    void OnTriggerEnter(Collider other)
    {
        other.transform.Translate(Offset);
        //other.GetComponent<PlayerTranslater>().Teleport(other.transform.position + Offset);
        Debug.Log(other.transform.position);
        Debug.Log("Teleported!");
    }
}
