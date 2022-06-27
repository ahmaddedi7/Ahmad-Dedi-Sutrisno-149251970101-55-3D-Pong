using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int player1Score, player2Score, player3Score, player4Score;
    public int maxScore;

    public BallController ball;
    public void removePlayer1Score(int decrement)
    {
        player1Score -= decrement;
        ball.ResetBall();
        if (player1Score == maxScore)
        {
            GameOver();
        }
    }
    public void removePlayer2Score(int decrement)
    {
        player2Score -= decrement;
        ball.ResetBall();
        if (player2Score == maxScore)
        {
            GameOver();
        }
    }

    public void removePlayer3Score(int decrement)
    {
        player3Score -= decrement;
        ball.ResetBall();
        if (player3Score == maxScore)
        {
            GameOver();
        }
    }

    public void removePlayer4Score(int decrement)
    {
        player4Score -= decrement;
        ball.ResetBall();
        if (player4Score == maxScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
