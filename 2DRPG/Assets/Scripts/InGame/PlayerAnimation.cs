using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isRunning", true);
        }
        else anim.SetBool("isRunning", false);

        if (Input.GetKey(KeyCode.F))
        {
            anim.SetBool("isAttacking", true);
        }    
        else anim.SetBool("isAttacking", false);
    }
}
