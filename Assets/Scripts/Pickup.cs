using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Pickup : Interactable
{
    public float holdDistance = 3;
    private bool Held;
    public GameObject camera;

    public override void Interact()
    {
        Debug.Log("Interacted");
        if (!Held)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<Rigidbody>().useGravity = false;
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
                transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
            }
            else
            {
                camera.GetComponentInParent<PlayerController>().CanLook = true;
            }
        }
    }
}
