using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TogglePause : MonoBehaviour
{
    [SerializeField] private GameObject[] ui_objects;
    [SerializeField] private Sprite[] sprites_pause;
    [SerializeField] new private Image renderer;


    void Start()
    {
        for(int i = 0;i < ui_objects.Length;i++)
        {
            ui_objects[i].SetActive(false);
        }
    }

    public void OnTogglePause(bool value)
    {
        for (int i = 0; i < ui_objects.Length; i++)
        {
            ui_objects[i].SetActive(value);
        }
        if (!value)
        {
            SoundManager.instance.PlaySE(1);
            renderer.sprite = sprites_pause[1];
        }
        else
        {
            renderer.sprite = sprites_pause[0];
        }
    }
}