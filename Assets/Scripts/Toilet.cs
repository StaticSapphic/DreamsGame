using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ShowAudioVolume))]
public class Toilet : MonoBehaviour
{
    public GameObject plane;
    private ShowAudioVolume volumeGetter;
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        volumeGetter = GetComponent<ShowAudioVolume>();
        rend = plane.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = Color.HSVToRGB(volumeGetter.clipLoudness, 1, 1);
    }
}
