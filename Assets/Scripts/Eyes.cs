using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    public RectTransform top;
    public RectTransform bottom;

    private bool opening = false;
    private bool closing = false;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Open();
    }

    // Update is called once per frame
    void Update()
    {
        if (opening && bottom.position.y >= -360)
        {
            top.position -= new Vector3(0, -speed, 0);
            bottom.position += new Vector3(0, -speed, 0);
            print(bottom.position.y);
        }
        else if (closing && bottom.position.y <= -5)
        {
            top.position += new Vector3(0, -speed, 0);
            bottom.position -= new Vector3(0, -speed, 0);
        }
    }

    public void Open()
    {
        opening = true;
        closing = false;
    }

    public void Close()
    {
        closing = true;
        opening = false;
    }
}
