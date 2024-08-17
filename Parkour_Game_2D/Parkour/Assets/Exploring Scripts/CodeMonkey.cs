using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeMonkey : MonoBehaviour
{

   /* enum PlayerAction
    {
        a,
        b,
        c,
        d

    }*/

    /*PlayerAction PA()
    {

        return PlayerAction.a;
        Debug.Log("");

    }
*/
    // Start is called before the first frame update
    void Start()
    {
        SetNumber();
    }
    public int RecursionIncrementer(int number)
    {
        if (number<5)
        {
            return number+1;
        }
        else
        {
            return number - 1;
        }

        
    }

    public void SetNumber()
    {

        
        Debug.Log(RecursionIncrementer(6));

    }
}
