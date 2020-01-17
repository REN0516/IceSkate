using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleFunction: MonoBehaviour
{
    [SerializeField] private GameObject selectbuttons;

    //セレクトボタン表示
    public void StartButtonFunction() 
    {
        gameObject.SetActive(false);

        selectbuttons.SetActive(true);   
    }

    //メインゲーム遷移
    public void MainButtonFunction()
    {
        LoadObject.transition_.Fade("MainGame");
    }

    //チュートリアル遷移
    public void TutorialFunction()
    {
        LoadObject.transition_.Fade("Tutorial");
    }
}
