using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionManager : MonoBehaviour
{
    [SerializeField] private GameObject[] ui_objects;

    void Start()
    {
        for(int i = 0;i < ui_objects.Length;i++)
        {
            ui_objects[i].SetActive(false);
        }
    }

    void Update()
    {
        
    }

    public void OnOpenOption()
    {
        for(int i = 0;i < ui_objects.Length; i++)
        {
            ui_objects[i].SetActive(true);
        }
    }

    public void OnCloseOption()
    {
        for(int i = 0;i < ui_objects.Length; i++)
        {
            ui_objects[i].SetActive(false);
        }
    }
}
