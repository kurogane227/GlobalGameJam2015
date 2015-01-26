using UnityEngine;
using System.Collections;

public class EnemyTrigger : MonoBehaviour 
{
	public GameObject player;
	public bool engage =false;
	public bool exit = false;
	public Vector3 exitPos;
		
	public float crashThreshold;
	
	private Enemy enemy;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindWithTag("Player");
		enemy = GetComponentInParent<Enemy>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter(Collider other)
	{
		if (other == player.collider && !enemy.dead) 
		{
			if(other.rigidbody.velocity.magnitude*other.rigidbody.velocity.magnitude > crashThreshold && enemy.currentState == Enemy.enemyStates.PATROL)
			{
				Debug.Log("KABOOM");
				Debug.Log(other.rigidbody.velocity.magnitude*other.rigidbody.velocity.magnitude);
				enemy.dead = true;
				enemy.Die(other.transform.position);
				enemy.currentState = Enemy.enemyStates.DEAD;
			}
			else
			{
				if(enemy.currentState == Enemy.enemyStates.PATROL)
				{
					engage = true;
					enemy.EngageSet();
					player.rigidbody.velocity = Vector3.zero;
				}
			}
			
		}
		
	}
	/*
	void OnTriggerExit (Collider other)
	{
		if (other == player.collider) 
		{
			engage = false;
			exitPos = transform.position;
			exitPos.x += (Random.Range(0,2) < 1) ? 100 : -100;
			exit = true;
		}
	}
	*/
}
