using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadObject : MonoBehaviour
{

    public static LoadObject transition_;
    [SerializeField] Fade fade = null;
    // Start is called before the first frame update
    void Start()
    {

        if (transition_ == null)
        {
            transition_ = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fade(string name)
    {
        fade.FadeIn(0.3f, () =>
        {
            SceneManager.LoadScene(name);
            fade.FadeOut(0.3f);
        });
        //SceneManager.LoadScene(name);
    }



}
