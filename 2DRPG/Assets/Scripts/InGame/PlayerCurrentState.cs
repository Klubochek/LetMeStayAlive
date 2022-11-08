using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCurrentState : MonoBehaviour
{
    

    [SerializeField] public int Health 
    {
        get=>health;
        set => OnHpChanged?.Invoke(health);
    }

    public readonly int MAXHEALTH=10;
    public Vector3 currentPlayerPosition = Vector3.zero;
    [SerializeField] private int health;
    public PlayersEvents playerEv;

    public Action<int> OnHpChanged;


    private void Awake()
    {
        PlayerData pd = DataManager.LoadPlayerData();
        health = pd.health;
        currentPlayerPosition = pd.playerPosition;
        GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position = currentPlayerPosition;
        playerEv = GetComponent<PlayersEvents>();
        playerEv.OnPickUpHealtPotion += AddHp;
    }
    public void AddHp(int value) 
    {
        
        health += value;
        OnHpChanged?.Invoke(health);
        return;
    }
    
}
