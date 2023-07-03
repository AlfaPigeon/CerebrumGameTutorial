using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSummoner : MonoBehaviour
{
    [Header("Summon Obstacles")]
    [SerializeField] private GameObject SummonObstacle;
    private void Start()
    {
        StartCoroutine(IE_SommonObstacle());
    }

    private IEnumerator IE_SommonObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            Summon();
        }
    }
    public void Summon()
    {
        Instantiate(SummonObstacle, transform.position, transform.rotation);
    }
}
