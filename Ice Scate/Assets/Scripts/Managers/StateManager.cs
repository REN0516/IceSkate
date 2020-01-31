using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public enum State
    {
        ACTIVE,
        PAUSE,
        GAMEOVER
    }
    public State state_ = State.ACTIVE;

    public static StateManager manager_;

    void Start()
    {
        manager_ = this;
    }
}
