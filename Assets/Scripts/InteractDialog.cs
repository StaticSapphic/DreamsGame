using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractDialog : Interactable
{
    public float delay = 1;
    public string[] messages;
    public TextMeshProUGUI mainText;
    public GameObject messageHolder;
    public override void Interact()
    {
        string message = messages[Random.Range(0, messages.Length)];
        mainText.text = message;
        StartCoroutine(displayText());        
    }

    IEnumerator displayText()
    {
        messageHolder.SetActive(true);
        yield return new WaitForSeconds(delay);
        messageHolder.SetActive(false);
    }
}
