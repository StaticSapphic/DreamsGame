using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    Transform playerTransform;
    UnityEngine.AI.NavMeshAgent myNavmesh;
    public float checkRate = 0.01f;
    float nextCheck;

    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.FindWithTag("Player").activeInHierarchy)
        {
            playerTransform = GameObject.FindWithTag("Player").transform;
        }
        myNavmesh = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextCheck)
        {
            nextCheck = Time.time + checkRate;
            FollowPlayer();
        }

    }

    void FollowPlayer()
    {
        myNavmesh.transform.LookAt(playerTransform);
        myNavmesh.destination = playerTransform.position;
    }
}
