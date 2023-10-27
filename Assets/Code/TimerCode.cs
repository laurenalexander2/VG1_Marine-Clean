using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

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
    private SubmarineHealth health;
    public GameObject player;
    //public DataManager data;

    [SerializeField]
    public DataManager data;

    private void Awake() {
        starScript = GetComponent<Stars>();
        health = player.GetComponent<SubmarineHealth>();

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
            }
            else if(timerOn = true && health.currentHealth <= 0 ){
                Debug.Log("Game Over");
                timeRemaining = 0;
                timerOn = false;
                UpdateEndScreenStars();
                HighscoreSave();
                endScreen.SetActive(true);

            } else {
                    Debug.Log("Game Over");
                    timeRemaining = 0;
                    timerOn = false;

                //end screen
                UpdateEndScreenStars();
                HighscoreSave();
                endScreen.SetActive(true);

              }
        }
    }

    void UpdateEndScreenStars()
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




    void Display(float timeDisplayed) {
    timeDisplayed += 1;
    float minutes = Mathf.FloorToInt(timeDisplayed / 60);
    float seconds = Mathf.FloorToInt(timeDisplayed % 60);
    GameText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void HighscoreSave(){
            string levelName = SceneManager.GetActiveScene().name;
            int levelNumber = 0;
            int starsAchieved = starScript.GetStarCount();
            if(levelName == "Demo Stage"){
                levelNumber = 1;
                if(starsAchieved > data.highscore1){
                    data.highscore1 = starsAchieved;
                }
            }else if(levelName == "LevelTwo"){
                levelNumber = 2;
                if(starsAchieved > data.highscore2){
                   data.highscore2 = starsAchieved;
                }
            }else if(levelName == "LevelThree"){
                levelNumber = 3;
                if(starsAchieved > data.highscore3){
                    data.highscore3 = starsAchieved;
                }
            }else if(levelName == "LevelFour"){
                levelNumber = 4;
                if(starsAchieved > data.highscore4){
                    data.highscore4 = starsAchieved;
                };
            }
        }


    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void MainMenu() {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Overworld Map");
        SceneManager.UnloadSceneAsync(scene);
    }

}