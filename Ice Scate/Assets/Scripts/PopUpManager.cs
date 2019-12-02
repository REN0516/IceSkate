﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons_;

    void Start()
    {
        for(int i = 0;i < buttons_.Length; i++)
        {
            buttons_[i].SetActive(false);
        }
    }
    
    public void OnOpenPopUp(int value)
    {
        buttons_[0].SetActive(false);
        buttons_[value].SetActive(true);
    }

    public void OnClosePopUp(int value)
    {
        buttons_[0].SetActive(true);
        buttons_[value].SetActive(false);
    }

    public void OnGoTitle()
    {
        if(LoadObject.transition_ != null)
        {
            LoadObject.transition_.Fade("Title");
        }
        else
        {
            SceneManager.LoadScene("Title");
        }
    }
}
