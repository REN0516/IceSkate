using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PopUpManager : MonoBehaviour
{
    [SerializeField] private GameManager manager;
    [SerializeField] private ContinueView viewer;
    [SerializeField] private GameObject[] ui_objects_;
    [SerializeField] private GameObject[] images_;
    [SerializeField] private Text result_text_;

    void Start()
    {
        for(int i = 0;i < images_.Length; i++)
        {
            images_[i].SetActive(false);
        }
    }

    void Update()
    {

        switch (GameManager.manager_.state_) {
            case GameManager.State.GAMEOVER:
                ToggleActive(true);
                break;
            case GameManager.State.ACTIVE:
                ToggleActive(false);
                break;
            case GameManager.State.RESULT:
                ui_objects_[1].SetActive(false);
                break;
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

    public void OnShowResult()
    {
        GameManager.manager_.state_ = GameManager.State.RESULT;
        result_text_.text = manager.GetScore().ToString();
        images_[3].SetActive(true);
        SoundManager.instance.StopBGM();
        SoundManager.instance.PlaySE(3);
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
        images_[2].SetActive(false);
    }
}
