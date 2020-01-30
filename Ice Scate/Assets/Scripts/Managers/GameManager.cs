using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ContinueView viewer;

    public enum State
    {
        ACTIVE,
        PAUSE,
        GAMEOVER
    }
    public State state_ = State.ACTIVE;

    public static GameManager manager_;

    void Start()
    {
        manager_ = this;
    }

    public void OnShowView()
    {
        viewer.ShowView();
    }
}
