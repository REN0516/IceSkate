using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeChange : MonoBehaviour
{
    [SerializeField] private Slider slider_bgm_;
    [SerializeField] private Slider slider_se_;

    void Start()
    {
        slider_bgm_.value = SoundManager.instance.GetBGMVolume();
        slider_se_.value = SoundManager.instance.GetSEVolume();
    }

    public void OnChangeVolumeBGM(float value)
    {
        SoundManager.instance.SetBGMVolume(value);
    }

    public void OnChangeVolumeSE(float value)
    {
        SoundManager.instance.SetSEVolume(value);
    }
}
