using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    //Create navmeshagent and target game object
    NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        //set this component to navmeshagent
        agent = this.GetComponent<NavMeshAgent>();
    }

    void Seek(Vector3 location)
    {
        //Set destination to target location
        agent.SetDestination(location);
    }
    // Update is called once per frame
    void Update()
    {
        //Chase target in direction
        Seek(target.transform.position);
    }
}
