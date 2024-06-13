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
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {

            if (Outside == true)
            {
                footstepsSound.enabled = true;
            }

            if (Inside == true)
             {
                footstepsSoundInside.enabled = true;
             }
        }
        else
        {
            footstepsSound.enabled = false;
            footstepsSoundInside.enabled = false;
        }
    }
}
