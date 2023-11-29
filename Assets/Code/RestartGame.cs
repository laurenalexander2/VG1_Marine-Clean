using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField]
    public DataManager data;
    // Start is called before the first frame update
    public void Reset()
    {
        data.highscore1 = 0;
        data.highscore2 = 0;
        data.highscore3 = 0;
        data.highscore4 = 0;
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Overworld Map");
        SceneManager.UnloadSceneAsync(scene);
    }
}
