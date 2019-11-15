using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private GameObject[] buttons_;

    void Start()
    {
        for(int i = 0;i < buttons_.Length; i++)
        {
            buttons_[i].SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public void OnOpenTitleMenu()
    {
        gameObject.SetActive(false);
        buttons_[1].SetActive(true);
    }

    public void OnCloseTitleMenu()
    {
        gameObject.SetActive(true);
        buttons_[1].SetActive(false);
    }

    public void OnOpenSoundMenu()
    {
        gameObject.SetActive(false);
        buttons_[0].SetActive(true);
    }

    public void OnCloseSoundMenu()
    {
        gameObject.SetActive(true);
        buttons_[0].SetActive(false);
    }

    public void OnGoTitle()
    {
        //SceneManager.LoadScene("Title");
    }
}
