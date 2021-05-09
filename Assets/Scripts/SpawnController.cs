using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] enemys;
    public Transform[] spawnPoints;
    public Transform EnemyPos;
    void Start()
    {
        StartCoroutine(EnemyIE());   
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator EnemyIE()
    {
        while (true)
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                int index = Random.Range(0, 2);
                if (index==0)
                {
                    GameObject go = Instantiate(enemys[0], spawnPoints[i].position, Quaternion.identity);
                    go.name = "Enemy";
                    go.transform.SetParent(EnemyPos);
                }
                else
                {
                    GameObject go = Instantiate(enemys[1], spawnPoints[i].position, Quaternion.identity);
                    go.name = "Enemy";
                    go.transform.SetParent(EnemyPos);

                }
            }
            yield return new WaitForSeconds(8);
        }
    }
}
