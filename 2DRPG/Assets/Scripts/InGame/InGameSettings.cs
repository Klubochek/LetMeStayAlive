using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSettings : MonoBehaviour
{
    public AudioSource FXStep, FXButtonClick;
    private SettingsData sd;

    void Update()
    {
        sd = SettingsManager.LoadSettings();
        FXStep.volume = sd.volumeOfSound;
        FXButtonClick.volume = sd.volumeOfSound;
    }
}
