using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TitleFunction: MonoBehaviour
{

    [SerializeField] private GameObject selectbuttons;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //セレクトボタン表示

    public void StartButtonFunction() 
    {

        gameObject.SetActive(false);

        selectbuttons.SetActive(true);

        
    }

    //メインゲーム遷移

    public void MainButtonFunction()
    {

        SceneManager.LoadScene("MainGame");

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

    //オプション機能表示

    public void OptionFunction()
    {



    }

}
