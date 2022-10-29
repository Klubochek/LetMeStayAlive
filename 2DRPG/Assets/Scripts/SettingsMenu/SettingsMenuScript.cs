using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour
{
    public AudioSource buttonFX;
    public GameObject settingsMenu;
    public Slider musicSlider;
    public Slider soundSlider;
    public void Start()
    {
        SettingsData sd=SettingsManager.LoadSettings();
        musicSlider.value = sd.volumeOfMusic;
        soundSlider.value = sd.volumeOfSound;
    }
    private void ButtonClickFX()
    {
        buttonFX.Play();
    }
    public void CloseSettingMenu() 
    {
        ButtonClickFX();
        settingsMenu.SetActive(false);
    }
    public void ApplySettings() 
    {
        ButtonClickFX();
        SettingsData setting = new SettingsData();
        setting.volumeOfMusic = musicSlider.value;
        setting.volumeOfSound = soundSlider.value;
        SettingsManager.SaveSettings(setting);
    }
    public void ToDefaultSettings() 
    {
        ButtonClickFX();
        SettingsData sd=SettingsManager.DeleteSettings();
        musicSlider.value = sd.volumeOfMusic;
        soundSlider.value = sd.volumeOfSound;
        ApplySettings();
    }
}
