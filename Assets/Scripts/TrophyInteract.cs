using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyInteract : Interactable
{
    public GameObject floor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Interact()
    {
        floor.SetActive(false);
    }
}
