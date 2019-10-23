using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedInteract : Interactable
{
    public string NextScene = "";

    public override void Interact()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(NextScene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
