using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    Rigidbody2D rigidbody_;
    [SerializeField] private int speed_ = 3;

    private Vector2 vector_;

    private float x_;
    private float y_;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            x_ = Input.GetAxis("Mouse X");
            y_ = Input.GetAxis("Mouse Y");
        }
        else
        {
            x_ = 0;
            y_ = 0;
        }

        vector_ = new Vector2(x_ * speed_, y_ * speed_);
        rigidbody_.AddForce(vector_);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        string name = c.gameObject.tag;
        if(name == "Obstacle_Stay" || name == "Obstacle_Move")
        {
            Debug.Log("障害物に当たりました");
        }
    }
}
