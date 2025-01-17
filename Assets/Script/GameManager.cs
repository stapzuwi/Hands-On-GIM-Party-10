using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Singleton
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null) Instance = this;
    }
    #endregion
    public float currentScore;
    public bool isPlaying = false;
    public GameObject gameOverMenu;
    public float gameSpeed;
    void Start()
    {
        currentScore = 0f;
        gameOverMenu.SetActive(false);
        gameSpeed = 1f;
        
    }
    private void Update()
    {
        if (isPlaying)
        {
            currentScore += 10f*Time.deltaTime;
        }
        else
        {
            gameOverMenu.SetActive(true);
        }
        if (gameSpeed < 3)
        {
            gameSpeed += Time.deltaTime/25;
        }
    }
    
    public void GameOver()
    {
        isPlaying = false;
    }

    public string Score()
    {
        return Mathf.RoundToInt(currentScore).ToString();
    }

}
