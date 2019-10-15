using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVscreen : MonoBehaviour
{
    public Texture2D screenImage;
    private MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
        Material material = new Material(Shader.Find("Standard"));
        material.SetTexture("_MainTex", screenImage);
        rend.material = material;
    }

    // Update is called once per frame
    void Update()
    {
       rend.material.mainTextureOffset = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));        
    }
}
