using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SharkCollision : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject timer;
    private TimerCode timerScript;
    private void Start(){
        timerScript = timer.GetComponent<TimerCode>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Shark")) {
            GameObject.Find("Timer").GetComponent<TimerCode>().updateEndScreenStars();
            endScreen.SetActive(true);
            timerScript.timerOn = false;

        }
    }
}
