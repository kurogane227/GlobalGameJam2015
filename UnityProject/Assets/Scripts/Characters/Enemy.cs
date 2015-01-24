using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public float patrolSpeed = 2f;
	public float chaseSpeed = 5f;
	public float chaseWaitTime =5f;
	public float patrolWaitTime =5f;
	public EnemyTrigger enemyTrigger;
	
	public Transform[] patrolWayPoints;

	private NavMeshAgent nav;
	private Transform player;
	private float chaseTimer;
	private float patrolTimer;
	private int wayPointIndex;

	// Use this for initialization
	void Start () 
	{
	
	}

	void Awake() 
	{
		nav = GetComponent<NavMeshAgent> ();
		wayPointIndex = Random.Range(0, patrolWayPoints.Length-1);
		//player = GameObject.FindGameObjectWithTag();
	}
	// Update is called once per frame
	void Update () 
	{

		if (enemyTrigger.engage)
			Engage ();
		else if (enemyTrigger.exit)
			Exit ();
		else
			Patrol ();
	}
	void Engage()
	{
		nav.Stop ();
	}

	void Chase ()
	{

	}

	void Patrol ()
	{
		nav.speed = patrolSpeed;
		if(patrolWayPoints.Length > 0)
			nav.SetDestination(patrolWayPoints[wayPointIndex].position);

		if (nav.remainingDistance <= nav.stoppingDistance) 
		{
			patrolTimer += Time.deltaTime;

			if (patrolTimer >= patrolWaitTime) 
			{
					wayPointIndex = Random.Range(0, patrolWayPoints.Length);
					patrolTimer = 0f;
			}
		}	 
		else
			patrolTimer = 0f;
	}
	void Exit ()
	{
		nav.speed = patrolSpeed * 2;
		nav.SetDestination(enemyTrigger.exitPos);
	}
}
