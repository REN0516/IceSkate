using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [SerializeField] private AudioSource source_bgm_;
    [SerializeField] private AudioSource source_se_;

    [SerializeField] private AudioClip[] clip_bgm_;
    [SerializeField] private AudioClip[] clip_se_;

    private float volume_bgm_ = 1;
    private float volume_se_ = 1;

    void Start()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        source_bgm_.volume = volume_bgm_;
        source_se_.volume = volume_se_;

        string name_scene_ = SceneManager.GetActiveScene().name;
        switch (name_scene_)
        {
            case "Title":
                PlayBGM(0);
                break;
            case "MainGame":
            case "Tutorial":
                PlayBGM(1);
                break;
        }
    }

    public void PlayBGM(int number)
    {
        if(source_bgm_.clip != clip_bgm_[number])
        {
            source_bgm_.Stop();
            source_bgm_.clip = clip_bgm_[number];
            source_bgm_.Play();
        }
        else
        {
            return;
        }
    }

    public void PlaySE(int number)
    {
        source_se_.PlayOneShot(clip_se_[number]);
    }

    public void SetBGMVolume(float value)
    {
        volume_bgm_ = value;
    }

    public void SetSEVolume(float value)
    {
        volume_se_ = value;
    }

    public float GetBGMVolume()
    {
        return volume_bgm_;
    }

    public float GetSEVolume()
    {
        return volume_se_;
    }
}
