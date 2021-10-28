using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject winCanvas;
    [SerializeField] private Text score;
    [SerializeField] private Text textOnWin;
    private Health healthPlayer;
    
    public enum GameState
    {
        Playing,
        GameOver,
        Win
    }

    public GameState gameState = GameState.Playing;
    void Start()
    {
        mainCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        winCanvas.SetActive(false);
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(gameOverCanvas.activeSelf);
        //state machine of the game
        switch (gameState)
        {
            case GameState.Playing:

                if (!healthPlayer.isAlive)
                {
                    gameState = GameState.GameOver;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                    winCanvas.SetActive(false);
                }
                else if (int.Parse(score.text) >= 66)
                {
                    gameState = GameState.Win;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(false);
                    winCanvas.SetActive(true);
                    textOnWin.text = "Winner Chicken Dinner! (" + score.text + ") points.";
                }
                break;
        }
    }
}
