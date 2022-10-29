using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InGameFX : MonoBehaviour
{
    public AudioSource fXStep;
    public AudioSource fXButton;

    public void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            fXStep.Play();
        }
        else fXStep.Stop();
    }


}
