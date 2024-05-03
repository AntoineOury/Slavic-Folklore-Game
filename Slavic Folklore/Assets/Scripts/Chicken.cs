using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chicken : MonoBehaviour
{
    //script from: https://www.youtube.com/watch?v=Zjlg9F3FRJs
    
    private NavMeshAgent agent;

    public GameObject Player;

    public float PlayerDistanceRun = 2.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        
        Debug.Log("Distance: " + distance);
        
        //chickens run away from player:
        if (distance < PlayerDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position + dirToPlayer;

            agent.SetDestination(newPos);
        }
    }
}
