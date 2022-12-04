using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text.SetText(GetCoins().ToString());
    }

    public static int GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }
    private void OnEnable()
    {
        EventManager.OnCoinGet += AddCoins;
        //EventManager.OnFoodGet += AddFood;
    }

    private void OnDisable()
    {
        EventManager.OnCoinGet -= AddCoins;
        //EventManager.OnFoodGet -= AddFood;
    }
    public void AddCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + amount);
        text.SetText(PlayerPrefs.GetInt("Coins").ToString());
    }
    
}
