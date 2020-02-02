using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleFunction : MonoBehaviour
{
    [SerializeField] private BannerViewScript banner;
    [SerializeField] private Text text_score;
    [SerializeField] private GameObject button_start;
    [SerializeField] private GameObject selectbutton;
    [SerializeField] private GameObject[] images_;
    [SerializeField] private Sprite[] sprite_button;

    private float alfa = 1f;
    [SerializeField]private float speed_fade = 0.05f;

    void Start()
    {
        text_score.text = ScoreManager.instance.GetScore().ToString();
    }

    //セレクトボタン表示
    public void StartButtonFunction()
    {
        SoundManager.instance.PlaySE(0);
        button_start.GetComponent<Image>().sprite = sprite_button[1];
        StartCoroutine(SwitchButton());
    }

    //メインゲーム遷移
    public void MainButtonFunction()
    {
        SoundManager.instance.PlaySE(0);
        selectbutton.transform.GetChild(0).GetComponent<Image>().sprite = sprite_button[1];
        banner.DestroyBanner();
        StartCoroutine(SwitchMainGame());
    }

    public void OnOpenPopUp(int value)
    {
        SoundManager.instance.PlaySE(0);
        selectbutton.transform.GetChild(value).GetComponent<Image>().sprite = sprite_button[1];
        StartCoroutine(SwitchOpenPopUp(value));
    }

    public void OnClosePopUp(int value)
    {
        SoundManager.instance.PlaySE(1);
        selectbutton.transform.GetChild(value).GetComponent<Image>().sprite = sprite_button[0];
        StartCoroutine(SwitchClosePopUp(value));
    }

    IEnumerator SwitchButton()
    {
        alfa = 1f;
        while (alfa >= 0f)
        {
            alfa -= speed_fade;
            button_start.GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            button_start.transform.GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
        alfa = 0f;

        button_start.SetActive(false);
        selectbutton.SetActive(true);

        while (alfa <= 1f)
        {
            alfa += speed_fade;
            selectbutton.transform.GetChild(0).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(0).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(1).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(1).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(2).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(3).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(3).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator SwitchOpenPopUp(int value)
    {
        alfa = 1f;
        while(alfa >= 0f)
        {
            alfa -= speed_fade;
            selectbutton.transform.GetChild(0).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(0).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(1).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(1).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(2).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(3).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(3).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
        images_[0].SetActive(false);
        images_[value].SetActive(true);
    }

    IEnumerator SwitchClosePopUp(int value)
    {
        alfa = 0f;

        images_[0].SetActive(true);
        images_[value].SetActive(false);

        while (alfa <= 1f)
        {
            alfa += speed_fade;
            selectbutton.transform.GetChild(0).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(0).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(1).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(1).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(2).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(3).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(3).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator SwitchMainGame()
    {
        alfa = 1f;
        while (alfa >= 0f)
        {
            alfa -= speed_fade;
            selectbutton.transform.GetChild(0).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(0).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(1).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(1).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(2).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(2).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);

            selectbutton.transform.GetChild(3).GetComponent<Image>().color = new Color(1f, 1f, 1f, alfa);
            selectbutton.transform.GetChild(3).GetChild(0).GetComponent<Text>().color = new Color(0f, 0f, 0f, alfa);
            yield return new WaitForEndOfFrame();
        }

        selectbutton.SetActive(false);
        LoadObject.transition_.Fade("MainGame");
    }
}