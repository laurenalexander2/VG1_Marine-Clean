using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreenBegin : MonoBehaviour
{
    public string sceneToLoad;

    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
