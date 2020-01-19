using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOption : MonoBehaviour
{
    [SerializeField] private GameObject[] ui_objects;

    void Start()
    {
        for(int i = 0;i < ui_objects.Length;i++)
        {
            ui_objects[i].SetActive(false);
        }
    }

    public void OnToggleOption(bool value)
    {
        for (int i = 0; i < ui_objects.Length; i++)
        {
            ui_objects[i].SetActive(value);
        }
        if (!value)
        {
            SoundManager.instance.PlaySE(1);
        }
    }
}