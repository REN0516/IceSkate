using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadObject : MonoBehaviour
{
    public static LoadObject transition_;
    [SerializeField] Fade fade = null;
    [SerializeField, Range(1, 5)] float time;

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

    public void Fade(string name)
    {
        fade.FadeIn(time, () =>
        {
            SceneManager.LoadScene(name);
            fade.FadeOut(time);
        });
    }
}
