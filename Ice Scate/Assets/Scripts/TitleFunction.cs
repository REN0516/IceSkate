using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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
      // SceneManager.LoadScene("MainGame");
    }

    //チュートリアル遷移
    public void TutorialFunction()
    {
        SceneManager.LoadScene("Tutorial");
    }

    //スコア表示
    public void ScoreFunction()
    {

    }
}
