using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    [SerializeField]private Animator anim;
    // Update is called once per frame
    void Update()
    {
        //Left Shift press to start sliding
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
                    
            anim.SetBool("isSliding", true);
        }

        //Left Shift release to stop sliding
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            
            anim.SetBool("isSliding", false);
        }
    }
}
