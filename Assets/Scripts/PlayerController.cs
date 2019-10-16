using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public Mesh editorMesh;

    [Header("Movement Speeds")]
    public float VerticalSpeed;
    public float HorizontalSpeed;

    [Header("Mouse Movement")]
    [Space]
    public float MouseXSensitivity;
    public float MouseYSenstivity;

    [Space]
    public float upLimit;
    public float downLimit;

    [Header("Running")]
    public bool CanRun = false;
    public KeyCode runKey;
    public float RunSpeed;


    private Camera camera;
    private float CameraPitch;


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
        controller.SimpleMove(transform.TransformDirection(new Vector3(Input.GetAxis("Horizontal") * HorizontalSpeed, 0, Input.GetAxis("Vertical") * (CanRun && Input.GetKey(runKey)? RunSpeed: VerticalSpeed))));

        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * MouseXSensitivity, 0));

        CameraPitch += Input.GetAxis("Mouse Y") * -MouseYSenstivity;
        CameraPitch = Mathf.Clamp(CameraPitch, -downLimit, upLimit);
        camera.transform.eulerAngles = new Vector3(CameraPitch, camera.transform.eulerAngles.y, camera.transform.eulerAngles.z);
    }

    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.green;
        Gizmos.DrawWireMesh(editorMesh, transform.position, transform.rotation, transform.localScale);
    }
}
