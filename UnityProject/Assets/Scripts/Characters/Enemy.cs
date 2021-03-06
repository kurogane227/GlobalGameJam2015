﻿using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour 
{
	public float patrolSpeed = 2f;
	public float chaseSpeed = 5f;
	public float chaseWaitTime =5f;
	public float patrolWaitTime =5f;
	public EnemyTrigger enemyTrigger;

	public Transform[] patrolWayPoints;
	
	public GameObject GameMain;

	private NavMeshAgent nav;
	private GameObject player;
	private float chaseTimer;
	private float patrolTimer;
	private int wayPointIndex;

	
	
	public enum enemyStates
	{
		PATROL,
		ENGAGE,
		DEAD,
		EXIT,
	}
	
	public enemyStates currentState;
	//public int promptOne;
	//public int promptTwo;
	//public int promptThree;
	
	 int[] promptThresholds;
	 string[] promptButtons;
	 int[] promptScore;
	 bool[] promptSuccess;
	 
	public int promptThresholdBuffer;
	
	public int promptIndex;
	
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

	public float engageTimer;
	public float engageTimeLimit;

	private UIManager UI;
	private GameManager gameMain;
	private GameObject _Persistent;
	
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
	};
	
	public bool dead = false;
	
	float timer;
	
	
	public	difficultyStates difficulty;
	
	private bool engageOver = false;
	// Use this for initialization
	void Start () 
	{
		nav.updateRotation = false;
		player = GameObject.FindWithTag("Player");
		_Persistent = GameObject.Find ("_SCRIPTS");
		UI = _Persistent.GetComponent<UIManager>();
		gameMain = _Persistent.GetComponent<GameManager>();
		
	}

	void Awake() 
	{
		nav = GetComponent<NavMeshAgent> ();
		wayPointIndex = Random.Range(0, patrolWayPoints.Length);
		currentState = enemyStates.PATROL;
		//player = GameObject.FindGameObjectWithTag();
	}
	// Update is called once per frame
	void Update () 
	{
		//Debug.Log(player.rigidbody.velocity.magnitude*player.rigidbody.velocity.magnitude);
		
		timer += Time.deltaTime;
		//if(timer > 1)
		{
			timer = 0;
		}
		if (dead && currentState == enemyStates.DEAD)
			{
			
			}
		else if (engageOver && currentState == enemyStates.EXIT)
			Exit ();
		else if(enemyTrigger.engage && currentState == enemyStates.ENGAGE)
			Engage ();
		else if(currentState == enemyStates.PATROL)
			Patrol ();
	}
	
	void Engage()
	{
		player.rigidbody.velocity = Vector3.zero;
		engageTimer+= Time.deltaTime;
		nav.Stop ();
		if(engageTimer >= 0)
			ProcessButtons();
		if(engageTimer > engageTimeLimit)
		{
			currentState = enemyStates.EXIT;
			engageOver = true;
			InputManager.disableTriggers = false;
			engageTimer = -1;
			enemyTrigger.engage = false;
			int engageSuccess = 0;
			int engageFailure = 0;
			
			//FIX LATER FOR MULTIPROMPTS
			//for(int i = 0; i < promptThresholds.Length; i++)
			for(int i = 0; i < 1; i++)
			{
				if(promptSuccess[i])
				{
					engageSuccess++;
				}
				else
				{
					engageFailure++;
				}
				if(engageSuccess >=  engageFailure)
				{
					//engage success
					//gameMain.groupScore++;
					Debug.Log ("EVENT SUCCESS");
				}
				else
				{
					//engage failure
					//gameMain.groupHealth--;
					Debug.Log ("EVENT FAILED");
				}
			}
			UI.HideEventBox();
		}
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
		InputManager.disableTriggers = true;
		currentState = enemyStates.ENGAGE;
		promptThresholds = new int[3];
		promptButtons = new string[3];
		promptSuccess = new bool[3];
		promptScore = new int[3];
		promptIndex = 0;
		
		engageOver = false;
		
		//int holdCheck = Random.Range(0,2);

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
		promptIndex = 0;
		
		//FIX LATER IF USING MULTIPROMPTS
		Debug.Log ("EVENT: " + promptButtons[0] + " " + promptThresholds[0]);
		UI.ShowEventBox(promptThresholds[0], promptButtons[0]);
		
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
	
	void ProcessButtons ()
	{
		if(Input.GetButtonDown("A_1"))
		{
			A_Press(1);
		}
		if(Input.GetButtonDown("A_2"))
		{
			A_Press(2);
			
		}
		if(Input.GetButtonDown("A_3"))
		{
			A_Press(3);
			
		}
		if(Input.GetButtonDown("A_4"))
		{
			A_Press(4);
			
		}
		if(Input.GetButtonDown("B_1"))
		{
			B_Press(1);
		}
		if(Input.GetButtonDown("B_2"))
		{
			B_Press(2);
			
		}
		if(Input.GetButtonDown("B_3"))
		{
			B_Press(3);
			
		}
		if(Input.GetButtonDown("B_4"))
		{
			B_Press(4);
			
		}
		if(Input.GetButtonDown("X_1"))
		{
			X_Press(1);
		}
		if(Input.GetButtonDown("X_2"))
		{
			X_Press(2);
			
		}
		if(Input.GetButtonDown("X_3"))
		{
			X_Press(3);
			
		}
		if(Input.GetButtonDown("X_4"))
		{
			X_Press(4);
			
		}
		if(Input.GetButtonDown("Y_1"))
		{
			Y_Press(1);
		}
		if(Input.GetButtonDown("Y_2"))
		{
			Y_Press(2);
			
		}
		if(Input.GetButtonDown("Y_3"))
		{
			Y_Press(3);
			
		}
		if(Input.GetButtonDown("Y_4"))
		{
			Y_Press(4);
			
		}
		/*
		if(Input.GetButton == "A_1"))
		{
			A_Button(1);
		}
		if(Input.GetButton == "A_2"))
		{
			A_Button(2);
			
		}
		if(Input.GetButton == "A_3"))
		{
			A_Button(3);
			
		}
		if(Input.GetButton == "A_4"))
		{
			A_Button(4);
			
		}
		if(Input.GetButton == "B_1"))
		{
			B_Button(1);
		}
		if(Input.GetButton == "B_2"))
		{
			B_Button(2);
			
		}
		if(Input.GetButton == "B_3"))
		{
			B_Button(3);
			
		}
		if(Input.GetButton == "B_4"))
		{
			B_Button(4);
			
		}
		if(Input.GetButton == "X_1"))
		{
			X_Button(1);
		}
		if(Input.GetButton == "X_2"))
		{
			X_Button(2);
			
		}
		if(Input.GetButton == "X_3"))
		{
			X_Button(3);
			
		}
		if(Input.GetButton == "X_4"))
		{
			X_Button(4);
			
		}
		if(Input.GetButton == "Y_1"))
		{
			Y_Button(1);
		}
		if(Input.GetButton == "Y_2"))
		{
			Y_Button(2);
			
		}
		if(Input.GetButton == "Y_3"))
		{
			Y_Button(3);
			
		}
		if(Input.GetButtonDown("Y_4"))
		{
			Y_Button(4);
			
		}
		*/
	}
	void A_Press (int pNum)
	{
		QTE("A", pNum);
	}
	void B_Press (int pNum)
	{
		QTE("B", pNum);
	}
	void X_Press (int pNum)
	{
		QTE("X", pNum);
	}
	void Y_Press (int pNum)
	{
		QTE("A", pNum);
	}
	void QTE(string button, int pNum)
	{
		bool wrongButton = true;
	
		if(engageTimer <= engageTimeLimit)
		{
		//FIX LATER IF USING MULTIPLE PROMPTS
			for(int j = 0; j < 1; j++)
			//for(int j = 0; j < promptThresholds.Length; j++)
			{
				if(button == promptButtons[j])
					wrongButton = false;
			}
			//FIX LATER IF USING MULTIPLE PROMPTS
			//for(int i = 0; i < promptThresholds.Length; i++)
			for(int i = 0; i < 1; i++)
			{
				promptScore[i]++;
				if(promptThresholds[i] > 0)
				{
					if(promptScore[i] < promptThresholds[i])
					{
						//UI is unsatisfied
						promptSuccess[i] = false;
					}
					else if (promptScore[i] >= promptThresholds[i] && promptScore[i] < promptThresholds[i] + promptThresholdBuffer)
					{
						//satisfy condition
						promptSuccess[i] = true;
					}
					else
					{
						//penalize player
						engageTimer = engageTimeLimit+1;
						promptSuccess[i] = false;
						SubtractScore(pNum);
					}
					UI.UpdateEventCount(promptScore[i]);
					
				}
				//for hold buttons if time permitted
				/*
				else if (promptThresholds[i] < 0)
				{
					if(promptScore[i] > promptThresholds[i])
					{
						//do a thing
						QTE_Success = false;
						
					}
					else if (promptScore[i] > promptThresholds[i] - promptThresholdBuffer)
					{
						//satisfy condition
						QTE_Success = true;
						
					}
					else
					{
						//penalize player
						promptScore[i]--;
						SubtractScore(pNum);
						QTE_Success = false;
						
					}	
				}
				*/
			}
			if (wrongButton)
			{
				SubtractScore(pNum);
			}
		}
		//time is up
		else
		{
		}
	}
	
	void AddScore(int pNum)
	{
		if (pNum == 1 )
			gameMain.p1Score++;
		else if (pNum == 2 )
			gameMain.p2Score++;
		else if (pNum == 3 )
			gameMain.p3Score++;
		else if (pNum == 4 )
			gameMain.p4Score++;
		
	}
	void SubtractScore(int pNum)
	{
	/*
		if (pNum == 1 )
			gameMain.p1Score-=2;
		else if (pNum == 2 )
			gameMain.p2Score-=2;
		else if (pNum == 3 )
			gameMain.p3Score-=2;
		else if (pNum == 4 )
			gameMain.p4Score-=2;	
	*/	
	}
}