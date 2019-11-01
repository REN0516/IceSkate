using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGameManager : MonoBehaviour
{
    [SerializeField] private Text score_text;

    void Start()
    {
        int i = 100;
        score_text.text = i.ToString();
    }

    void Update()
    {
        
    }
}
