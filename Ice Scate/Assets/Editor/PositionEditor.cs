using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class PositionEditor : EditorWindow
{
    private int padding = 20;
    private int id = 0;

    private GameObject obstacle_stay;
    private GameObject obstacle_move;

    private GameObject[] objects_stay;
    private GameObject[] objects_move;

    private string file_json = "";

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

        obstacle_stay = (GameObject)EditorGUILayout.ObjectField("obstacle_stay", obstacle_stay, typeof(GameObject), true);
        obstacle_move = (GameObject)EditorGUILayout.ObjectField("obstacle_move", obstacle_move, typeof(GameObject), true);

        GUILayout.Space(padding);

        if (GUILayout.Button("セーブ"))
        {
            if(id < 0)
            {
                Debug.Log("セーブエラー");
                Debug.Log("要素番号は0以上にしてください");
                return;
            }

            file_json = "Stage/" + id.ToString() + ".txt";
            PositionData data = new PositionData();

            objects_stay = GameObject.FindGameObjectsWithTag("Obstacle_Stay");
            objects_move = GameObject.FindGameObjectsWithTag("Obstacle_Move");

            data.data_count_move = objects_move.Length;
            data.data_count_stay = objects_stay.Length;

            data.data_position_move = new Vector3[objects_move.Length];
            data.data_position_stay = new Vector3[objects_stay.Length];

            for(int i = 0;i < objects_move.Length; i++)
            {
                data.data_position_move[i] = objects_move[i].transform.position;
            }
            for(int i = 0;i < objects_stay.Length; i++)
            {
                data.data_position_stay[i] = objects_stay[i].transform.position;
            }

            var json = JsonUtility.ToJson(data);

            try
            {
                using (StreamWriter writer = new StreamWriter(file_json, false))
                {
                    //ファイルの上書き
                    writer.Write(json);
                    //writer.Flush(); //一時的なバッファクリア
                    writer.Close();
                }
                Debug.Log("セーブ成功");
            }
            catch (System.Exception e)
            {
                Debug.Log("セーブ失敗:" + e.ToString());
            }
        }

        GUILayout.Space(padding);

        if (GUILayout.Button("ロード"))
        {
            Debug.Log("ロード");
            file_json = "Stage/" + id.ToString() + ".txt";
            FileInfo info = new FileInfo(file_json);
            if (!info.Exists)
            {
                Debug.Log("セーブファイルが見つかりません");
                return;
            }
            string json = ReadTextFile(file_json);

            GameObject[] object_stay = GameObject.FindGameObjectsWithTag("Obstacle_Move");

            GameObject[] object_move = GameObject.FindGameObjectsWithTag("Obstacle_Stay");

            //シーンのオブジェクトを全削除
            if(object_stay != null)
            {
                for(int i = 0;i < object_stay.Length; i++)
                {
                    //DestroyImmediateは非推奨らしい
                    DestroyImmediate(object_stay[i]);
                }
            }
            if(object_move != null)
            {
                for(int i = 0;i < object_move.Length; i++)
                {
                    DestroyImmediate(object_move[i]);
                }
            }

            if (json != null)
            {
                PositionData data = JsonUtility.FromJson<PositionData>(json);
                for(int i = 0;i < data.data_count_stay; i++)
                {
                    Instantiate(obstacle_stay, data.data_position_stay[i], Quaternion.identity);
                }
                for(int i = 0;i < data.data_count_move; i++)
                {
                    Instantiate(obstacle_move, data.data_position_move[i], Quaternion.identity);
                }
                Debug.Log("ロード成功");
            }
            else
            {
                Debug.Log("ロード失敗");
            }
        }
    }

    string ReadTextFile(string file)
    {
        string data = null;

        try
        {
            using (StreamReader reader = new StreamReader(file))
            {
                data = reader.ReadToEnd();
            }
        }
        catch (System.Exception e)
        {
            Debug.Log("読み込み失敗" + e.ToString());
        }

        return data;
    }
}

public class PositionData {
    public int data_count_stay;
    public int data_count_move;
    public Vector3[] data_position_stay;
    public Vector3[] data_position_move;
}