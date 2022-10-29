using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class DataManager 
{
    public static void SavePlayerData(PlayerData playerData)
    {
        string path = "E:\\Setting.json";
        File.WriteAllText(path, JsonUtility.ToJson(playerData));
    }
    public static PlayerData LoadPlayerData()
    {
        string path = "E:\\Setting.json";
        if (File.Exists(path))
        {
            PlayerData pd = JsonUtility.FromJson<PlayerData>(File.ReadAllText(path));
            return pd;
        }
        else
        {
            PlayerData dp = new PlayerData();
            File.WriteAllText(path, JsonUtility.ToJson(dp));
            PlayerData pd = JsonUtility.FromJson<PlayerData>(File.ReadAllText(path));
            return pd;
        }
    }
    public static PlayerData DeletePlayerData()
    {
        string path = "E:\\Setting.json";
        File.Delete(path);
        PlayerData pd = new PlayerData();
        return pd;
    }
}
