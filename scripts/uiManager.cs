using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class uiManager : MonoBehaviour
{    public Button[] buttons;
     public Text scoreText;
     bool gameOver;
     public int score;
    // Start is called before the first frame update
    void Start()
    {
       //ui = FindObjectOfType<uiManager>();
       gameOver = false;
       score = 0;
       InvokeRepeating("scoreUpdate", 1.0f ,0.5f);
       //scoreText.text = "Score:" + score; 
    }

    // Update is called once per frame
    void Update()
    {  
      
      scoreText.text = "Score:" + score;
      //score += 1;
      
    }
    void scoreUpdate(){
        if (!gameOver){
        score += 1;
        }
    }
    public void gameOverActivate(){
        gameOver = true;
        foreach(Button button in buttons){
            button.gameObject.SetActive(true);
        }
    }
    public void play(){
       // Application.LoadLevel ("level 1");
       SceneManager.LoadScene("level 1");
    }

    public void Pause() {
        if (Time.timeScale == 1) {
            Time.timeScale = 0;
        }
        else if(Time.timeScale == 0) {
            Time.timeScale = 1;
        }
    } 
    public void Replay() {
        SceneManager.LoadScene("level 1");

    }
    public void Menu(){
        SceneManager.LoadScene("menu scene");

    }
    public void exit(){
        Application.Quit();
    }
}
