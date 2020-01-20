using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    private Rigidbody2D rigidbody_;
    private Animator animator_;
    [SerializeField] private int speed_ = 8;

    private Vector2 vector_;

    private float power_x_;
    private float power_y_;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
        animator_ = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            power_x_ = Input.GetAxis("Mouse X");
            power_y_ = Input.GetAxis("Mouse Y");
            if(power_x_ > 1)
            {
                power_x_ = 1;
                Debug.Log(power_x_);
            }
            else if(power_x_ < -1)
            {
                power_x_ = -1;
                Debug.Log(power_x_);
            }
            if (power_y_ > 1)
            {
                power_y_ = 1;
                Debug.Log(power_y_);
            }
            else if(power_y_ < -1)
            {
                power_y_ = -1;
                Debug.Log(power_y_);
            }
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
        animator_.SetFloat("X", power_x_);
        animator_.SetFloat("Y", power_y_);
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
