using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ObstacleGroup : MonoBehaviour
{
    [Header("Summoning spots")]
    [SerializeField] private Transform[] SummonSpots;
    [Header("Summon Obstacles")]
    [SerializeField] private GameObject SummonObstacle;

    private void Start()
    {
        Setup();
        Destroy(gameObject, 5f);
    }
    void Setup()
    {
        int free_space = Random.Range(0, SummonSpots.Length);
        for (int i = 0; i < SummonSpots.Length; i++)
        {
            if (i != free_space) {
                GameObject _g = Instantiate(SummonObstacle, SummonSpots[i].position, SummonSpots[i].rotation);
                _g.transform.SetParent(transform);
            }
        }
    }


}
