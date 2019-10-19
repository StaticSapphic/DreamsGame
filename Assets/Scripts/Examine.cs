using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examine : Interactable
{
    public GameObject MessageHolder;
    public string[] InspectMessages;
    public float messageLength = 3;
    public GameObject RealObject;

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
        if (RealObject != null)
        {
            if (RealObject.GetComponent<Animation>() != null)
            {
                RealObject.GetComponent<Animation>().Play();
            }
        }
        
    }
}
