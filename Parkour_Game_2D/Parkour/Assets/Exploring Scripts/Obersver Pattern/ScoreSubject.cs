using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSubject
{
    private List<IObserver> listOfObservers = new List<IObserver>();
    int score;

    public int Score
    {
        get { return score; }
        set { score = value;
            NotifyObeservers();
        
        }
        
    }

    public void Attach(IObserver observer)
    {

        listOfObservers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        listOfObservers.Remove(observer);
    }

    public void NotifyObeservers()
    {
        foreach (IObserver observer in listOfObservers)
        {
            observer.Update(score);
        }

    }
}
