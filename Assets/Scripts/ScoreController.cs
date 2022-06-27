using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    public Text Player1Score,
                Player2Score,
                Player3Score,
                Player4Score;

    public ScoreManager manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player1Score.text = manager.player1Score.ToString();
        Player2Score.text = manager.player2Score.ToString();
        Player3Score.text = manager.player3Score.ToString();
        Player4Score.text = manager.player4Score.ToString();
    }
}
