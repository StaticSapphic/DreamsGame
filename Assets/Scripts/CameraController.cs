using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float CameraPitch;
    public float MouseYSenstivity;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraPitch += Input.GetAxis("Mouse Y") * MouseYSenstivity;
        CameraPitch = Mathf.Clamp(CameraPitch, 90, -45);
    }
}
