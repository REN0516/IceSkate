using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFunction: MonoBehaviour
{
    [SerializeField] private BannerViewScript banner;
    [SerializeField] private GameObject button_start;
    [SerializeField] private GameObject selectbuttons;
    [SerializeField] private GameObject[] images_;

    //セレクトボタン表示
    public void StartButtonFunction() 
    {
        button_start.SetActive(false);
        selectbuttons.SetActive(true);
        SoundManager.instance.PlaySE(0);
    }

    //メインゲーム遷移
    public void MainButtonFunction()
    {
        LoadObject.transition_.Fade("MainGame");
        SoundManager.instance.PlaySE(0);
        selectbuttons.SetActive(false);
        banner.DestroyBanner();
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
}
