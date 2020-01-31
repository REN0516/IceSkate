using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFunction: MonoBehaviour
{
    [SerializeField] private BannerViewScript banner;
    [SerializeField] private GameObject selectbuttons;

    //セレクトボタン表示
    public void StartButtonFunction() 
    {
        gameObject.SetActive(false);
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
}
