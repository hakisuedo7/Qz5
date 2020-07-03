using UnityEngine;
using System.Collections;

public class AutoMove2 : MonoBehaviour {
    UnityEngine.AI.NavMeshAgent ball;
    Transform[] goals;
    Vector3 curGoal;
	// Use this for initialization
	void Start () {
        ball = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        goals = GameObject.Find("goal").GetComponentsInChildren<Transform>();
        curGoal = goals[Random.Range(0, 4)].position;
        ball.SetDestination(curGoal);
    }
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(curGoal, this.transform.position) < 1.0f)
        {
            curGoal = goals[Random.Range(1, 5)].position;
            ball.SetDestination(curGoal);
        }
	}
}
