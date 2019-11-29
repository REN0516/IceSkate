using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    enum TYPE {
        stay,
        move,
    }
    [SerializeField] TYPE type_;

    private float speed_;
    void Start()
    {
        if(type_ == TYPE.move)
        {
            speed_ = 10;
            //x座標が0以上のときの処理
            if(transform.position.x > 0)
            {
                if(speed_ > 0)
                {
                    speed_ *= -1;
                }
            }
            else　//x座標が0以下のときの処理
            {
                if (speed_ < 0)
                {
                    speed_ *= -1;
                }
            }
        }
        else
        {
            speed_ = 7;
        }
    }

    void Update()
    {
        switch (type_)
        {
            case TYPE.stay:
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - speed_, 0);
                break;
            case TYPE.move:
                transform.localPosition = new Vector3(transform.localPosition.x + speed_, transform.localPosition.y, 0);
                break;
        }
    }
}
