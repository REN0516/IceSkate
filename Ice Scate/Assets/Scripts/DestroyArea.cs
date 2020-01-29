using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D c)
    {
        string name = c.gameObject.tag;
        if(name == "Obstacle_Stay" || name == "Obstacle_Move")
        {
            Destroy(c.gameObject);
        }
    }
}
