using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSound;
    public AudioSource footstepsSoundInside;
    public bool Outside;
    public bool Inside;

    void Update()
    {

        if (Outside == true)
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                footstepsSound.enabled = true;
            }
            
        }
        else
        {
            footstepsSound.enabled = false;
        }

        if (Inside == true)
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                footstepsSoundInside.enabled = true;
            }
            
        }

        else
        {
            footstepsSoundInside.enabled = false;
        }

    }
}
