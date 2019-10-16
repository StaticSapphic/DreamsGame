using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorController : MonoBehaviour
{
    public GameObject Player;
    public Vector3 Offset;


    void OnTriggerEnter(Collider other)
    {
        Player.transform.Translate(Offset);
        Debug.Log("Teleported!");
        Debug.Log(other.transform);
    }
}
