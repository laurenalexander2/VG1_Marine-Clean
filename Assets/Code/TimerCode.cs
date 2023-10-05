using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCode : MonoBehaviour
{
    // Start is called before the first frame update

    public float timeRemaining = 10;
    public bool timerOn = false;
    public Text GameText;
    public GameObject endScreen;

    private void Start() {
        timerOn = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(timerOn) {
            if(timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
            Display(timeRemaining);
            } else {
                    Debug.Log("Game Over");
                    timeRemaining = 0;
                    timerOn = false;

                //end screen
                endScreen.SetActive(true);
              }
        }
    }
    void Display(float timeDisplayed) {
    timeDisplayed += 1;
    float minutes = Mathf.FloorToInt(timeDisplayed / 60);
    float seconds = Mathf.FloorToInt(timeDisplayed % 60);
    GameText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}