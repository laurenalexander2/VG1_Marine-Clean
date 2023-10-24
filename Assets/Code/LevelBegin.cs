using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;


public class LevelBegin : MonoBehaviour
{
[SerializeField]
public DataManager data;
       public string nextSceneName;
       public GameObject StartScreen;
       public KeyCode activationKey = KeyCode.Space; // Change this to the desired activation key
       private LevelInfo InfoScript;
       public Button Play;
       private Rigidbody2D rb;

       //private static Button commonPlay;
    void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;
        if (Input.GetKey(activationKey) && (collision.gameObject.CompareTag("Player") == true))
        {
        SetButtonFunc(() => LoadScene(nextSceneName));
            //SetButtonFunc(LoadScene);
            //Debug.Log("activates");
            if(InfoScript.completed == true){
                    Debug.Log("it collides!");
                    StartScreen.SetActive(true);
                    //Play.onClick.AddListener();
                    //SceneManager.LoadScene(nextSceneName);

            }else if(gameObject.name == "Level 1"){
                Debug.Log("it collides!");
                StartScreen.SetActive(true);
                //Play.onClick.AddListener(SceneManager.LoadScene(nextSceneName));

                //SceneManager.LoadScene(nextSceneName);
            }
        }

    }
    void OnTriggerEnter2D(Collider2D collider){
        if(Input.GetKey(activationKey) && (collider.gameObject.CompareTag("Player") == true)){
            SetButtonFunc(() => LoadScene(nextSceneName));
            StartScreen.SetActive(true);
        }
    }
public void SetButtonFunc(UnityAction action){
    Play.onClick.RemoveAllListeners();
    Play.onClick.AddListener(action);
    //SceneManagerLoadScene(scene);
}
void LoadScene(string sceneName){
    Debug.Log("button was pressed");
    SceneManager.LoadScene(sceneName);
}
public void BackButton(){
    Debug.Log("button was pressed");
    StartScreen.SetActive(false);
}
//public void Play(){
   // SceneManager.LoadScene(nextSceneName);
//}
 void Start() {
   InfoScript = gameObject.GetComponent<LevelInfo>();
    rb = GetComponent<Rigidbody2D>();
}


}