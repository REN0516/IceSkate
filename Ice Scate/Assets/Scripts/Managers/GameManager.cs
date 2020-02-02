using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public enum State
    {
        ACTIVE,
        PAUSE,
        GAMEOVER,
        RESULT,
    }
    public State state_ = State.ACTIVE;

    public static GameManager manager_;

    [SerializeField] private GameObject image_result;
    [SerializeField] private Text score_text_;
    [SerializeField] private int speed_count;

    private float tmp_score_ = 0f;
    private int score_ = 0;

    void Start()
    {
        manager_ = this;
    }

    void Update()
    {
        if (state_ == State.ACTIVE)
        {
            {
                tmp_score_ += 1f / 60f * speed_count;
                score_ = (int)tmp_score_;
                if (score_ > 10000000)
                {
                    score_ = 9999999;
                }
            }
        }

        score_text_.text = score_.ToString();
    }

    public int GetScore()
    {
        return score_;
    }

    public void OnGoTitle()
    {
        if (LoadObject.transition_ != null)
        {
            LoadObject.transition_.Fade("Title");
        }
        else
        {
            SceneManager.LoadScene("Title");
        }
        SoundManager.instance.PlaySE(0);
        image_result.SetActive(false);
        ScoreManager.instance.UpdateScore(score_);
    }
}
