using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PositionEditor : EditorWindow
{
    private int padding = 20;
    private int id = 0;
    [MenuItem("PositionEditor/ShowWondow")]
    static void ShowWindow()
    {
        GetWindow<PositionEditor>();
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("やりたい項目を選んでください");
        
        GUILayout.Space(padding);

        id = EditorGUILayout.IntField("番号", id);

        GUILayout.Space(padding);

        if (GUILayout.Button("セーブ"))
        {
            Debug.Log("セーブ");
        }

        GUILayout.Space(padding);

        if (GUILayout.Button("ロード"))
        {
            Debug.Log("ロード");
        }
    }
}
