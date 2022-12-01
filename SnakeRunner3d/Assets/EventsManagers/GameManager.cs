using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinScore;

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
        //GUIManager.UpdateCoins();
        //GUI new value;
    }
}
