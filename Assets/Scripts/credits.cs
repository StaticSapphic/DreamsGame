using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    private RectTransform position;
    public float speed = 1;
    void Start()
    {
        position = GetComponent<RectTransform>();
    }
    void Update()
    {
        if (position.position.y < 790)
        {
            position.position -= new Vector3(0, -speed, 0);
        }
        
    }
}
