using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePause : MonoBehaviour
{
    public enum State {
        PAUSE,
        ACTIVE
    }
    public State state_ = State.ACTIVE;


    [SerializeField] private GameObject[] ui_objects_;
    [SerializeField] private Sprite[] sprites_pause_;
    [SerializeField] private Image renderer_;

    void Start()
    {
        for(int i = 0;i < ui_objects_.Length;i++)
        {
            ui_objects_[i].SetActive(false);
        }
    }

    public void OnTogglePause(bool value)
    {
        for (int i = 0; i < ui_objects_.Length; i++)
        {
            ui_objects_[i].SetActive(value);
        }
        if (!value)
        {
            SoundManager.instance.PlaySE(1);
            renderer_.sprite = sprites_pause_[1];
            GameStateManager.manager_.state_ = GameStateManager.State.ACTIVE;
        }
        else
        {
            renderer_.sprite = sprites_pause_[0];
            GameStateManager.manager_.state_ = GameStateManager.State.PAUSE;
        }
    }
}