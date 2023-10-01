using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    private int playerLives = 3;
    private int playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives = " + playerLives + "  Score = " + playerScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseScoreBy(int score)
    {
        playerScore += score;

        Debug.Log("Lives = " + playerLives + "  Score = " + playerScore);
    }

    public void decreaseLivesBy(int life)
    {
        playerLives -= life;

        if (playerLives > 0)
        {
            Debug.Log("Lives = " + playerLives + "  Score = " + playerScore);
        }
        else
        {
            Debug.Log("Game Over!");
        }
    }
}
