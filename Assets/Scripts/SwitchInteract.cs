using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteract : Interactable
{
    public Light roomLight;
    public bool LightOn = true;
    public override void Interact()
    {
        if (LightOn)
        {
            GetComponent<AudioSource>().Play();
            roomLight.intensity = 0.1f;
            gameObject.transform.localScale = new Vector3(1,-1, 1);


        }
        else
        {
            GetComponent<AudioSource>().Play();
            roomLight.intensity = 1.0f;
            gameObject.transform.localScale = new Vector3(1, 1, 1);
            
        }
        LightOn = !LightOn;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
