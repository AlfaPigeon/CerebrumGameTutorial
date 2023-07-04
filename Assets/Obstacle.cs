using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private ObstacleGroup obstacleGroup;
    private void Start()
    {
        obstacleGroup = transform.parent.GetComponent<ObstacleGroup>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

            obstacleGroup.OnHit(collision.tag);

    }
}
