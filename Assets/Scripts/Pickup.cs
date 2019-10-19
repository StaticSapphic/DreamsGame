using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pickup : Interactable
{
    public float holdDistance = 1;
    private bool Held;
    public GameObject camera;
    [Header("Inspection Messages")]
    public GameObject MessageHolder;
    public string[] InspectMessages;
    public float messageLength = 3;

    public override void Interact()
    {
        Debug.Log("Interacted");
        if (!Held)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().useGravity = false;

            if (InspectMessages.Length > 0)
            {
                MessageHolder.GetComponent<Messages>().ShowText(InspectMessages[Random.Range(0, InspectMessages.Length)], messageLength);
            }
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<Rigidbody>().useGravity = true;
        }
        Held = !Held;
    }

    void Update()
    {
        
        if (Held)
        {
            transform.position = camera.transform.position + (camera.transform.forward * holdDistance);
            if (Input.GetAxis("Fire3") == 1)
            {
                camera.GetComponentInParent<PlayerController>().CanLook = false;
                transform.Rotate(new Vector3(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0));
            }
            else
            {
                camera.GetComponentInParent<PlayerController>().CanLook = true;
            }
        }
    }
}
