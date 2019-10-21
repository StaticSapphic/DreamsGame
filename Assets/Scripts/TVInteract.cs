using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteract : Interactable
{
    public Texture2D Black;
    public bool on;
    public GameObject Light;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().materials[1].SetTexture("_MainTex", Black);
    }

    public override void Interact()
    {
        if (on)
        {
            GetComponent<MeshRenderer>().materials[1].SetTexture("_MainTex", Black);
            GetComponent<AudioSource>().Stop();
            Light.SetActive(false);
        }
        else
        {
            GetComponent<TVscreen>().GenerateImage();
            GetComponent<AudioSource>().Play();
            Light.SetActive(true);
        }
        
        on = !on;
    }
}
