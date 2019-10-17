using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : Interactable
{
    private Vector3 OriginalPosition;
    private Quaternion OriginalRotation;
    public float holdDistance = 3;
    private bool Held;
    public GameObject camera;

    public override void Interact()
    {
        Debug.Log("Picked Up");
        if (!Held)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            OriginalPosition = transform.position;
            OriginalRotation = transform.rotation;
            camera.GetComponentInParent<PlayerController>().CanMove = false;
            camera.GetComponentInParent<PlayerController>().CanLook = false;
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
            transform.position = OriginalPosition;
            transform.rotation = OriginalRotation;
            camera.GetComponentInParent<PlayerController>().CanMove = true;
            camera.GetComponentInParent<PlayerController>().CanLook = true;
        }
        Held = !Held;
    }

    void Update()
    {
        if (Held)
        {
            transform.position = camera.transform.position + (camera.transform.forward * holdDistance);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
        }
    }
}
