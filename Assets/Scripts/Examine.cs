using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examine : Interactable
{
    public GameObject MessageHolder;
    public string[] InspectMessages;
    public float messageLength = 3;

    public override void Interact()
    {
        if (InspectMessages.Length > 0)
        {
            MessageHolder.GetComponent<Messages>().ShowText(InspectMessages[Random.Range(0, InspectMessages.Length)], messageLength);
        }
        if (GetComponent<AudioSource>() != null)
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
