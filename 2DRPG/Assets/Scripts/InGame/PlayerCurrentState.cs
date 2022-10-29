using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCurrentState : MonoBehaviour
{
    public int health;
    public int maxHealth=10;
    public Vector3 currentPlayerPosition = Vector3.zero;

    private void Start()
    {
        PlayerData pd = DataManager.LoadPlayerData();
        health = pd.health;
        currentPlayerPosition = pd.playerPosition;
        GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position = currentPlayerPosition;
    }
}
