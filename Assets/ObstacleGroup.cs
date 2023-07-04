using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ObstacleGroup : MonoBehaviour
{
    [Header("Summoning spots")]
    [SerializeField] private Transform[] SummonSpots;
    [Header("Summon Obstacles")]
    [SerializeField] private GameObject SummonObstacle;

    private ScoreManager scoreManager;
    private PlayerController player;
    private bool Lock = false;
    private void Start()
    {
        player = FindObjectOfType<PlayerController>();
        scoreManager = FindObjectOfType<ScoreManager>();
        Setup();
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

    public void OnHit(string tag)
    {
        if (Lock) return;

        switch (tag)
        {
            case "ScoreCounter":
                Lock = true;
                scoreManager.SetScore(scoreManager.Score + 1);
                break;

            case "Player":
                Lock = true;
                player.Die();
                break;



        }

        

    }

}
