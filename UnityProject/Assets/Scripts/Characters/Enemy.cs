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

	//public int promptOne;
	//public int promptTwo;
	//public int promptThree;
	
	public int[] promptThresholds;
	public string[] promptButtons;
	public int promptIndex;
	
	public int promptTimer;

	[SerializeField]
	private int easyMin;
	[SerializeField]
	private int easyMax;
	[SerializeField]
	private int medMin;
	[SerializeField]
	private int medMax;
	[SerializeField]
	private int hardMin;
	[SerializeField]
	private int hardMax;

	public enum difficultyStates 
	{
		EASY,
		MEDIUM,
		HARD
	};
	
	public float deathForce;
	public float deathRadius;
	
	string[] buttonList = new string[]
	{
		"A",
		"B",
		"X",
		"Y",
		"LB",
		"RB",
		"LSL",
		"LSR",
		"RSL",
		"RSR",
	};
	
	public bool dead = false;
	
	public	difficultyStates difficulty;
	// Use this for initialization
	void Start () 
	{
		
	}

	void Awake() 
	{
		nav = GetComponent<NavMeshAgent> ();
		wayPointIndex = Random.Range(0, patrolWayPoints.Length);
		//player = GameObject.FindGameObjectWithTag();
	}
	// Update is called once per frame
	void Update () 
	{
		if (dead)
			{
			
			}
		else if(enemyTrigger.engage)
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

	public void EngageSet()
	{
		promptThresholds = new int[6];
		promptButtons = new string[6];
		promptIndex = 0;
		
		int holdCheck = Random.Range(0,2);

		promptThresholds[promptIndex] = PromptRange();
		promptButtons[promptIndex] = SetButtonPrompt();
		
		promptIndex++;
				
		if (difficulty == difficultyStates.MEDIUM || difficulty == difficultyStates.HARD)
		{
			promptButtons[promptIndex] = SetButtonPrompt();
			promptThresholds[promptIndex] = PromptRange();
			
			promptIndex++;

		}
		else if (difficulty == difficultyStates.HARD)
		{
			promptButtons[promptIndex] = SetButtonPrompt();
			promptThresholds[promptIndex] = PromptRange();
		}
	}
	
	int PromptRange()
	{
		int rangeCheck;
		if (difficulty == difficultyStates.EASY)
		{
			return Random.Range(easyMin, easyMax);
		}
		else if(difficulty == difficultyStates.MEDIUM)
		{
			rangeCheck = Random.Range(0,3);
			if (rangeCheck > 0)
				return Random.Range(medMin, medMax);
			else
				return Random.Range(easyMin, easyMax);
			//todo: hold prompts
		}
		else if(difficulty == difficultyStates.HARD)
		{
			rangeCheck = Random.Range(0,3);
			if (rangeCheck > 0)
				return Random.Range(hardMin, hardMax);
			else
				return Random.Range(medMin, medMax);
			//todo: hold prompts
		}
		else
			return 0;
	}
	string SetButtonPrompt()
	{
		return buttonList[Random.Range(0, buttonList.Length)];
	}
	
	void SetHoldPrompts()
	{
		for (int i = promptIndex; i < 3; i++)
		{
			
		}
	}
	public void Die(Vector3 forcePos)
	{
		nav.Stop();
		nav.enabled = false;
		rigidbody.isKinematic = false;
		forcePos.y = -10;
		Vector3 newTorque = new Vector3();
		newTorque.x = Random.Range (-100,100);
		newTorque.y = Random.Range (-100,100);
		newTorque.z = Random.Range (-100,100);
		rigidbody.AddTorque(newTorque);
		rigidbody.AddExplosionForce(deathForce, forcePos, deathRadius);
	}
}
