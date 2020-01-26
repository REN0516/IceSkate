using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContorller : MonoBehaviour
{
    public enum State {
        Active,
        Pause
    }
    public State state = State.Active;

    private Rigidbody2D rigidbody_;
    private Animator animator_;
    [SerializeField] private int speed_ = 8;

    private Vector2 vector_;

    private float power_x_;
    private float power_y_;
    private float animation_x_;
    private float animation_y_;

    void Start()
    {
        rigidbody_ = GetComponent<Rigidbody2D>();
        animator_ = GetComponent<Animator>();
    }

    void Update()
    {
        if(state == State.Active)
        {
            if (Input.GetMouseButton(0))
            {
                power_x_ = Input.GetAxis("Mouse X");
                power_y_ = Input.GetAxis("Mouse Y");
                if (power_x_ > 1f)
                {
                    power_x_ = 1f;
                }
                else if (power_x_ < -1f)
                {
                    power_x_ = -1f;
                }
                if (power_y_ > 1f)
                {
                    power_y_ = 1f;
                }
                else if (power_y_ < -1f)
                {
                    power_y_ = -1f;
                }
                if (power_x_ != 0f && power_y_ != 0f)
                {
                    animation_x_ = power_x_;
                    animation_y_ = power_y_;
                }
            }
            else
            {
                power_x_ = 0f;
                power_y_ = 0f;
            }

            if (Input.GetMouseButtonDown(0))
            {
                rigidbody_.velocity = Vector2.zero;
            }
        }
        else if(state == State.Pause)
        {
            rigidbody_.velocity = Vector2.zero;
        }

        vector_ = new Vector2(power_x_ * speed_, power_y_ * speed_);
        rigidbody_.AddForce(vector_);
        animator_.SetFloat("X", animation_x_);
        animator_.SetFloat("Y", animation_y_);
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
