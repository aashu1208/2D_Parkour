using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour, IObserver
{
    public Text scoreText;

    public void Update(int score)
    {

        scoreText.text = score.ToString();
    }

    
}

public class AchievementSystem: MonoBehaviour, IObserver
{

    public void Update(int score)
    {
        if (score>=100)
        {
            Debug.Log("Achievements Unlocked");
        }
    }

}
