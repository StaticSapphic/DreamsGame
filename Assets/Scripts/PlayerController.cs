using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float VerticalSpeed;
    public float HorizontalSpeed;

    public float MouseXSensitivity;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        controller.SimpleMove(transform.TransformDirection( new Vector3(Input.GetAxis("Horizontal") * HorizontalSpeed, 0, Input.GetAxis("Vertical") * VerticalSpeed) ));
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*MouseXSensitivity, 0));
    }
}
