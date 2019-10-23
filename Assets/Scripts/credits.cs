using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (position.position.y < 1100)
        {
            position.position -= new Vector3(0, -speed, 0);
        }
        else
        {
            StartCoroutine(LoadYourAsyncScene());
        }
        
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Bedroom");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
