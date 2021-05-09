using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform player;
    public float minDis;
    public float dist;
    private int hp = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         dist = Vector3.Distance(player.position, transform.position);
        if (dist>minDis)
        {
            agent.SetDestination(player.transform.position);

        }
        else
        {
            agent.ResetPath();
        }
        if (hp>=3)
        {
            GameManager.Instance.score += 10;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Bullet")
        {
            hp++;
           
        }
    }
}
