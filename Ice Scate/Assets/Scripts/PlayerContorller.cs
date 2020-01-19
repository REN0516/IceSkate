using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    Rigidbody2D rigidbody_;
    [SerializeField] private int speed_ = 3;

    private Vector2 vector_;

    private float power_x_;
    private float power_y_;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            power_x_ = Input.GetAxis("Mouse X");
            power_y_ = Input.GetAxis("Mouse Y");
        }
        else
        {
            power_x_ = 0;
            power_y_ = 0;
        }
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody_.velocity = Vector3.zero;
        }

        vector_ = new Vector2(power_x_ * speed_, power_y_ * speed_);
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
