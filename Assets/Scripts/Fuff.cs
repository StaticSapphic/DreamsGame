using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Fuff : MonoBehaviour
{
    public float LookDuration;
    private float currentLookTime;
    private bool looking = false;

    void OnBecameInvisible()
    {
        currentLookTime = 0;
        looking = false;
    }

    void OnBecameVisible()
    {
        looking = true;
    }

    void Update()
    {
        if (looking)
        {
            currentLookTime += Time.deltaTime;
        }
        if (currentLookTime >= LookDuration)
        {
            currentLookTime = 0;
            GetComponent<AudioSource>().Play();
        }
    }
}
