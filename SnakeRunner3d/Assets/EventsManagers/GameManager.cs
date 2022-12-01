using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnCoinGet += AddCoins;
        
    }

    private void OnDisable()
    {
        EventManager.OnCoinGet += AddCoins;
    }
    private void AddCoins(int coins)
    {
        CoinManager.AddCoins(coins);
        //GUI new value;
    }
}
