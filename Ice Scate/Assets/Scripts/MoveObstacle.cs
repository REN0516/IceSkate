using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacle : MonoBehaviour
{
    [SerializeField] private float speed_;
    void Start()
    {
        
    }

    void Update()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + speed_, transform.localPosition.y, 0);
    }
}
