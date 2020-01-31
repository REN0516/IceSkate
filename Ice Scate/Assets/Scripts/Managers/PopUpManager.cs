using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] private ContinueView viewer;
    [SerializeField] private GameObject[] ui_objects_;
    [SerializeField] private GameObject[] images_;

    void Start()
    {
        for(int i = 0;i < images_.Length; i++)
        {
            images_[i].SetActive(false);
        }
    }

    void Update()
    {
        if (GameManager.manager_.state_ == GameManager.State.GAMEOVER)
        {
            ToggleActive(true);
        }
        else if (GameManager.manager_.state_ == GameManager.State.ACTIVE)
        {
            ToggleActive(false);
        }
    }

    void ToggleActive(bool value)
    {
        for (int i = 0; i < ui_objects_.Length; i++)
        {
            ui_objects_[i].SetActive(value);
        }
    }

    public void OnShowView()
    {
        viewer.ShowView();
    }

    public void OnOpenPopUp(int value)
    {
        images_[0].SetActive(false);
        images_[value].SetActive(true);
        SoundManager.instance.PlaySE(0);
    }

    public void OnClosePopUp(int value)
    {
        images_[0].SetActive(true);
        images_[value].SetActive(false);
        SoundManager.instance.PlaySE(1);
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
        SoundManager.instance.PlaySE(0);
        images_[2].SetActive(false);
    }
}
