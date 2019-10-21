using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject player;
    public GameObject credits;
    public GameObject HUD;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!won)
        {
            if (player.transform.position.y <= -500)
            {
                //We won, lock player, lock camera, play credits, profit?
                won = true;
                player.GetComponent<Rigidbody>().useGravity = false;
                player.GetComponent<Rigidbody>().isKinematic = false;
                player.GetComponent<Rigidbody>().velocity = Vector3.zero;
                credits.SetActive(true);
                HUD.SetActive(false);
            }
        }
    }
}
