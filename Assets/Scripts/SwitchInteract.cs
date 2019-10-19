using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInteract : Interactable
{
    public Light roomLight;
    public GameObject switchOn;
    public GameObject switchOff;
    public bool LightOn = true;

    public AudioSource Noise;
    public override void Interact()
    {
        Debug.Log("Toggled Light");
        if (LightOn)
        {
            Noise.Play();
            roomLight.intensity = 0.1f;
            switchOn.SetActive(false);
            switchOff.SetActive(true);
            switchOff.GetComponent<SwitchInteract>().LightOn = false;
            

        }
        else
        {
            Noise.Play();
            roomLight.intensity = 1.0f;
            switchOn.SetActive(true);
            switchOff.SetActive(false);
            switchOn.GetComponent<SwitchInteract>().LightOn = true;
            
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
