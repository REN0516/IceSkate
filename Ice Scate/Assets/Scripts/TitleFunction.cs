using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFunction: MonoBehaviour
{
    [SerializeField] private BannerViewScript banner;
    [SerializeField] private Text text_score;
    [SerializeField] private GameObject button_start;
    [SerializeField] private GameObject selectbuttons;
    [SerializeField] private GameObject[] images_;

    private float alfa = 1f;

    void Start()
    {
        text_score.text = ScoreManager.instance.GetScore().ToString();
    }

    //セレクトボタン表示
    public void StartButtonFunction() 
    {
        SoundManager.instance.PlaySE(0);
        StartCoroutine(SwitchButton());
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

    IEnumerator SwitchButton()
    {
        alfa = 1f;
        while(alfa >= 0f)
        {
            alfa -= 0.01f;
            button_start.GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            button_start.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
        alfa = 0f;

        button_start.SetActive(false);
        selectbuttons.SetActive(true);

        while (alfa <= 1f)
        {
            alfa += 0.01f;
            selectbuttons.transform.GetChild(0).GetComponent<Image>().color = new Color(0f, 0f, 0f, alfa);
            selectbuttons.transform.GetChild(0).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbuttons.transform.GetChild(1).GetComponent<Image>().color = new Color(0f, 0f, 0f, alfa);
            selectbuttons.transform.GetChild(1).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            
            selectbuttons.transform.GetChild(2).GetComponent<Image>().color = new Color(0f, 0f, 0f, alfa);
            selectbuttons.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            
            selectbuttons.transform.GetChild(3).GetComponent<Image>().color = new Color(0f, 0f, 0f, alfa);
            selectbuttons.transform.GetChild(3).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
        
    }
}
