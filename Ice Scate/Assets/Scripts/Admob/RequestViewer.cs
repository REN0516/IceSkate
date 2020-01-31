using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestViewer : MonoBehaviour
{
    [SerializeField] private ContinueView viewer;
    [SerializeField] private GameObject[] ui_objects_;

    void Update()
    {
        if(StateManager.manager_.state_ == StateManager.State.GAMEOVER)
        {
            ToggleActive(true);
        }
        else if(StateManager.manager_.state_ == StateManager.State.ACTIVE)
        {
            ToggleActive(false);
        }
    }

    void ToggleActive(bool value)
    {
        for(int i = 0;i < ui_objects_.Length; i++)
        {
            ui_objects_[i].SetActive(value);
        }
    }

    public void OnShowView()
    {
        viewer.ShowView();
    }
}
