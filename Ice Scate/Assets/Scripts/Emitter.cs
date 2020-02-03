using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    private GameObject object_wave_;

    [SerializeField] private GameObject obstacle_stay;
    [SerializeField] private GameObject obstacle_move;

    private int id;

    private float time_ = 3f;

    private string file_json = "";

    void Update()
    {
        if(GameManager.manager_.state_ == GameManager.State.ACTIVE)
        {
            time_ -= Time.deltaTime;
        }

        if (time_ <= 0f)
        {
            object_wave_ = new GameObject("wave");

            // WaveをEmitterの子要素にする
            object_wave_.transform.parent = transform;

            id = Random.Range(0, 5);
            Create(id);

            time_ = 3f;
        }
    }

    void Create(int id)
    {
        file_json = Resources.Load<TextAsset>("Stage/" + id.ToString()).text;

        if (file_json != "")
        {
            Data data = JsonUtility.FromJson<Data>(file_json);
            for (int i = 0; i < data.data_count_stay; i++)
            {
                Instantiate(obstacle_stay, data.data_position_stay[i], Quaternion.identity).transform.parent = object_wave_.transform;
            }
            for (int i = 0; i < data.data_count_move; i++)
            {
                Instantiate(obstacle_move, data.data_position_move[i], Quaternion.identity).transform.parent = object_wave_.transform;
            }
            Debug.Log("ロード成功");
        }
    }

    void CreateWave()
    {
        //// Waveを作成する
        //GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

        //// WaveをEmitterの子要素にする
        //wave.transform.parent = transform;

        //// Waveの子要素のEnemyが全て削除されるまで待機する
        //while (wave.transform.childCount != 0)
        //{
        //    yield return new WaitForEndOfFrame();
        //}

        ////Waveの削除
        //Destroy(wave);
    }
}

public class Data
{
    public int data_count_stay;
    public int data_count_move;
    public Vector3[] data_position_stay;
    public Vector3[] data_position_move;
}