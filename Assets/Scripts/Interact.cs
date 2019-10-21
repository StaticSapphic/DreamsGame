using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float Reach;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * Reach, Color.green);

        if (Input.GetButtonDown("Interact"))
        {
            RaycastHit hit;
            // Does the ray intersect any objects
            if (Physics.Raycast(transform.position, transform.forward, out hit, Reach))
            {                
                hit.collider.GetComponent<Interactable>()?.Interact();
            }
        }
    }
}
