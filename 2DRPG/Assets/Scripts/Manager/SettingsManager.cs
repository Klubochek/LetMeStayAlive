using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Rendering;

public static class SettingsManager 
{
    
    public static void SaveSettings(SettingsData settingsData)
    {
        string path = Path.Combine(Application.dataPath, "Setting.json");
        File.WriteAllText(path, JsonUtility.ToJson(settingsData));
    }
    public static SettingsData LoadSettings() 
    {
        string path = Path.Combine(Application.dataPath, "Setting.json");
        if (File.Exists(path))
        {
            SettingsData sd = JsonUtility.FromJson<SettingsData>(File.ReadAllText(path));
            return sd;
        }
        else
        {
            SettingsData ds = new SettingsData();
            File.WriteAllText(path, JsonUtility.ToJson(ds));
            SettingsData sd = JsonUtility.FromJson<SettingsData>(File.ReadAllText(path));
            return sd;
        }
    }
    public static SettingsData DeleteSettings() 
    {
        string path= Path.Combine(Application.dataPath, "Setting.json");
        File.Delete(path);
        SettingsData sd = new SettingsData();
        return sd;
    }
}
