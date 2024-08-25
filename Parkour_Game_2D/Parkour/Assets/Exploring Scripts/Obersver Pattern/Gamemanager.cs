using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public ScoreSubject ss;
    public ScoreDisplay sd;
    public AchievementSystem achS;

    // Start is called before the first frame update
    void Start()
    {
        ss = new ScoreSubject();

        ss.Attach(sd);
        ss.Attach(achS);

        ss.Score = 10;
        ss.Score = 50;
        ss.Score = 100;

    }
}
