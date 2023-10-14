using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


//public class LevelBegin : MonoBehaviour
//{
  // public string nextSceneName;

    //void OnCollisionEnter2D(Collision2D other){
       // Debug.Log("it collides!");
        //if(other.gameObject.CompareTag("level")){
          //  SceneManager.LoadScene(nextSceneName);
        //}
    //}
//}
public class LevelBegin : MonoBehaviour
{
       public string nextSceneName;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("it collides!");
            SceneManager.LoadScene(nextSceneName);
        }

    }

}