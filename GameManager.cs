using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startButton;
    public PlayerDeath player;

  // public GameObject gameOver;
    public float countTimer = 5;
    public Text scoreText; 
    public Text CollectText;
    public GameObject restartButton;
    private int score;
    private int Collect;
    public Trigger ring;
    public SpawnSpikes spikes;
    public GameObject Player;
    public ParticleSystem PlayerBurst;
    public GameObject demo;

    // Start is called before the first frame update
    void Start()
    {
        Player.SetActive(false);
        Time.timeScale = 0;
        score = 0;
        startButton.SetActive(true);
        restartButton.SetActive(false);
        
    }

    private void Update()
    {
        if( player.isDead )
        {
            PlayerBurst.Emit( 10);
            
            countTimer -= Time.unscaledDeltaTime;
            GameOver();
        }
     
        if(countTimer < 4)
        {
            RestartGame();
        }
    }

    public void StartGame()
    {
        restartButton.SetActive(false);
        startButton.SetActive(false);
        Time.timeScale = 1;
        UpdateScore(0);
        Player.SetActive(true);
    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score+"";
    }
    public void UpdateCollectable(int MushroomToAdd)
    {
        Collect += MushroomToAdd;
        CollectText.text =  Collect+"";
    }

    public void GameOver()
    {  
        if (countTimer < 5)
        {
            Player.SetActive(false);
        }
            if (countTimer < 4.5)
        {

            Time.timeScale = 0;

        }
        
        
    }


    public void RestartGame()
    {
       
        restartButton.SetActive(true);
        
    }
    public void ResetGame()
    {
      
        SceneManager.LoadScene("Gameplay");    
    
    }
  public  void Demo()
    {
        demo.SetActive(true);
    } 
    public  void DemoExit()
    {
        demo.SetActive(false);
    }
    

}


