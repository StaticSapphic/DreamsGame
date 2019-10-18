using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVscreen : MonoBehaviour
{
    public Texture2D screenImage;
    private MeshRenderer rend;

    public bool move = true;

    public int resX;
    public int resY;

    // Start is called before the first frame update
    void Start()
    {
        //GenerateImage();
    }

    public void GenerateImage()
    {
        screenImage = new Texture2D(resX, resY, TextureFormat.ARGB32, false);

        for (int x = 0; x < 1280; x++)
        {
            for (int y = 0; y < 720; y++)
            {
                float value = Random.Range(0f, 1f);
                screenImage.SetPixel(x, y, new Color(value, value, value));
            }
        }

        screenImage.Apply();

        rend = GetComponent<MeshRenderer>();
        Material material = new Material(Shader.Find("Standard"));
        material.SetTexture("_MainTex", screenImage);
        rend.material = material;
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            rend.material.mainTextureOffset = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        }
    }
}
