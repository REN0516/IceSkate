using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Text score_text;

    private float tmp_score = 0f;
    private int score = 0;

    void Start()
    {

    }

    void Update()
    {
        tmp_score += Time.deltaTime;
        score = (int)tmp_score;
        if(score > 10000000)
        {
            score = 9999999;
        }
        score_text.text = score.ToString();
    }
}
