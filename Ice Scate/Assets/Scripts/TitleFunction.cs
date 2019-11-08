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
    public void StartButtonFunction() 
    {

        gameObject.SetActive(false);

        selectbuttons.SetActive(true);

        
    }
    public void MainButtonFunction()
    {

        SceneManager.LoadScene("MainGame");

    }

    public void TutorialFunction()
    {

        SceneManager.LoadScene("Tutorial");

    }

}
