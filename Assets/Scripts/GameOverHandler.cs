using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using TMPro; 

public class GameOverHandler : MonoBehaviour
{

    [SerializeField] private AsteroidSpawner asteroidSpawner;
    [SerializeField] private GameObject gameOverDisplay;  
    [SerializeField] private TMP_Text gameOverText; 
    [SerializeField] private ScoreSystem scoreSystem; 
    
    public void EndGame()
    {
        asteroidSpawner.enabled = false;
        int finalScore = scoreSystem.EndTimer();
        gameOverText.text = $"Your Score: {finalScore}";
        gameOverDisplay.gameObject.SetActive(true);
        gameObject.SetActive(true); 
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene(1); 
    }
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0); 
    }
    
}
