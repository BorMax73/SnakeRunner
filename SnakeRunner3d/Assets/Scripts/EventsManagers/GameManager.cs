using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinScore;

    [SerializeField]
    private int _foodScore;

    private void OnEnable()
    {
        EventManager.OnCoinGet += AddCoins;
        EventManager.OnFoodGet += AddFood;
    }

    private void OnDisable()
    {
        EventManager.OnCoinGet += AddCoins;
        EventManager.OnFoodGet -= AddFood;
    }
    private void AddCoins(int coins)
    {
        Debug.Log("Coins: ");
        CoinManager.AddCoins(coins);
        //GUIManager.UpdateCoins();
        //GUI new value;
    }

    private void AddFood(int foodValue)
    {
        _foodScore += foodValue;
        Debug.Log("Food: " + _foodScore);
    }
}
