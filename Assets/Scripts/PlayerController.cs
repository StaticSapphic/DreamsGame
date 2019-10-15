using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;

    public float VerticalSpeed;
    public float HorizontalSpeed;

    [Space]
    public float MouseXSensitivity;
    public float MouseYSenstivity;

    private Camera camera;
    private float CameraPitch;

    [Space]
    public float upLimit;
    public float downLimit;


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        camera = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        controller.SimpleMove(transform.TransformDirection( new Vector3(Input.GetAxis("Horizontal") * HorizontalSpeed, 0, Input.GetAxis("Vertical") * VerticalSpeed) ));
        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X")*MouseXSensitivity, 0));

        CameraPitch += Input.GetAxis("Mouse Y") * -MouseYSenstivity;
        CameraPitch = Mathf.Clamp(CameraPitch, -downLimit, upLimit);
        camera.transform.eulerAngles = new Vector3(CameraPitch, camera.transform.eulerAngles.y, camera.transform.eulerAngles.z);
    }
}
