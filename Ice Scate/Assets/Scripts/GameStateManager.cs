using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public enum State
    {
        ACTIVE,
        PAUSE,
        GAMEOVER
    }
    public State state_ = State.ACTIVE;

    public static GameStateManager manager_;

    void Start()
    {
        manager_ = this;
    }
}
