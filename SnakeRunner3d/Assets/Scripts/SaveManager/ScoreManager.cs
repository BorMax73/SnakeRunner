using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int GetBestScore()
    {
        return PlayerPrefs.GetInt("BestScore", 0);
    }

    public static void SetBestScore(int score)
    {
        if (score > GetBestScore())
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }
    
    
  }

