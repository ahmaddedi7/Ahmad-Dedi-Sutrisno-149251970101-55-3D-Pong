using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    public SphereCollider ball;
    public bool isPlayer1, isPlayer2, isPlayer3, isPlayer4;
    public ScoreManager manager;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        if (isPlayer1)
        {
            manager.removePlayer1Score(1);
        }
        else if (isPlayer2)
        {
            manager.removePlayer2Score(1);
        }
        else if (isPlayer3)
        {
            manager.removePlayer3Score(1);
        }
        else if (isPlayer4)
        {
            manager.removePlayer4Score(1);
        }
    }
}
