using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Messages : MonoBehaviour
{
    public TextMeshProUGUI messageDisplayer;
    public Image messageBackground;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText(string Message, float delay)
    {
        StartCoroutine(Show(Message, delay));
    }

    IEnumerator Show(string Message, float delay)
    {
        //messageDisplayer.gameObject.SetActive(true);
        messageDisplayer.text = Message;
        messageBackground.gameObject.SetActive(true);
        yield return new WaitForSeconds(delay);
        //messageDisplayer.gameObject.SetActive(false);
        messageDisplayer.text = "";
        messageBackground.gameObject.SetActive(false);
    }
}
