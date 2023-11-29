using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WinGame : MonoBehaviour
{
public KeyCode activationKey = KeyCode.Space;
public string sceneToLoad;
            private void OnTriggerEnter2D(Collider2D other)
            {
                // Check if the colliding GameObject has the "Player" tag
                if (Input.GetKey(activationKey) && other.CompareTag("Player"))
                {
                    // Load the specified scene
                    string scene = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(sceneToLoad);
                    SceneManager.UnloadSceneAsync(scene);

                }
            }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
