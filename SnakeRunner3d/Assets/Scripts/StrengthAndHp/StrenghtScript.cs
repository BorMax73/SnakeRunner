using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StrenghtScript : MonoBehaviour
{
    [SerializeField] private int strenght;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text.SetText(strenght.ToString());
    }

    private void OnEnable()
    {
        EventManager.OnFoodGet += OnFoodGet;
    }

    private void OnDisable()
    {
        EventManager.OnFoodGet -= OnFoodGet;
    }

    private void OnFoodGet(int value)
    {
        strenght += value;
        text.SetText(strenght.ToString());
    }
}
