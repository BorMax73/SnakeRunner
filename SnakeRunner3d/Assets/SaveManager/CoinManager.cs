using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static int GetCoins()
    {
        return PlayerPrefs.GetInt("Coins");
    }
    
    public static void AddCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + amount);
    }
    
}
