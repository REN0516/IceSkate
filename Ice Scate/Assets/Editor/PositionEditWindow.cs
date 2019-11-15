using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PositionEditWindow : EditorWindow
{
    private int id = 0;
    private int padding = 20;

    [MenuItem("PositionEditor/PositionEditWindow")]
    static void ShowWindow()
    {
        GetWindow<PositionEditWindow>();
    }

    void OnGUI()
    {
        //文字列を張り付ける
        EditorGUILayout.LabelField("項目を選んでください");

        GUILayout.Space(padding);

        //入力用のフィールド
        id = EditorGUILayout.IntField("番号",id);

        //項目間の余白
        GUILayout.Space(padding);

        //ボタンの表示と実行処理
        if (GUILayout.Button("セーブ", GUILayout.Height(30)))
        {
            Debug.Log("セーブ");
        }

        GUILayout.Space(padding);

        if (GUILayout.Button("ロード", GUILayout.Height(30)))
        {
            Debug.Log("ロード");
        }
    }
}
