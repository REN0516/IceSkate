using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int high_score = 0;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        high_score = PlayerPrefs.GetInt("Score", 0);
    }

    public int GetScore()
    {
        return high_score;
    }

    public void UpdateScore(int score)
    {
        if(score > high_score)
        {
            high_score = score;
            PlayerPrefs.SetInt("Score", high_score);
        }
    }
}
