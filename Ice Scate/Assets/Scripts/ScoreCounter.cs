using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private Text score_text_;

    private float tmp_score_ = 0f;
    private int score_ = 0;

    void Start()
    {

    }

    void Update()
    {
        if (StateManager.manager_.state_ == StateManager.State.ACTIVE)
        {
            {
                tmp_score_ += Time.deltaTime;
                score_ = (int)tmp_score_;
                if (score_ > 10000000)
                {
                    score_ = 9999999;
                }
            }
        }

        score_text_.text = score_.ToString();
    }
}
