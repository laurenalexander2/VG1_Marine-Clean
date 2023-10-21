using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private SceneLoad instance;
    private string currentscene;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    IEnumerator LoadNewScene(string newSceneName, string currentscene)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(newSceneName, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        if (asyncLoad.isDone)
        {
            Debug.Log(newSceneName + " was Loaded asyncly!");
            StartCoroutine(Unloadscene(currentscene));
            currentscene = newSceneName;
        }
    }

    IEnumerator Unloadscene(string oldSceneName)
    {
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(oldSceneName);

        while (!asyncUnload.isDone)
        {
            yield return null;
        }

        if (asyncUnload.isDone)
        {
            Debug.Log(oldSceneName + " was unloaded asyncly!");
        }
    }
}
