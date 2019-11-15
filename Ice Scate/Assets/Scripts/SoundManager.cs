using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
