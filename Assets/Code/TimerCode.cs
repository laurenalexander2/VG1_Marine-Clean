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
    public Image endStar1;
    public Image endStar2;
    public Image endStar3;
    public Stars starScript;

    private void Awake() {
        starScript = GetComponent<Stars>();
    }

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

                //UpdateEndScreenStars();
              }
        }
    }

    /*void UpdateEndScreenStars()
    {
        int starsAchieved = starScript.GetStarCount();

        // Initially set all to false
        endStar1.enabled = false;
        endStar2.enabled = false;
        endStar3.enabled = false;

        // Enable stars based on the count
        if (starsAchieved >= 1) endStar1.enabled = true;
        if (starsAchieved >= 2) endStar2.enabled = true;
        if (starsAchieved >= 3) endStar3.enabled = true;
    }
    */

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