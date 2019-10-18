using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVInteract : Interactable
{
    public Texture2D Black;
    public bool on;
    

    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<TVscreen>().gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", Black);
    }

    public override void Interact()
    {
        if (on)
        {
            GetComponentInChildren<TVscreen>().gameObject.GetComponent<MeshRenderer>().material.SetTexture("_MainTex", Black);
            GetComponentInChildren<AudioSource>().Stop();
        }
        else
        {
            GetComponentInChildren<TVscreen>().GenerateImage();
            GetComponentInChildren<AudioSource>().Play();
        }
        
        on = !on;
    }
}
