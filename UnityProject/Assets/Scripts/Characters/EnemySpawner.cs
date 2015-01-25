using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour 
{
	public Enemy enemyPrefab;

	public List <Transform> waypoints;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
		}
	}
	void SpawnEnemy()
	{
		Enemy enemy;
		enemy = Instantiate (enemyPrefab, transform.position, transform.rotation) as Enemy;
		Transform[] waypointsArray = this.gameObject.GetComponentsInChildren<Transform>();
		waypoints.AddRange(waypointsArray);
		waypoints.RemoveAt (0);
		enemy.patrolWayPoints = waypoints.ToArray();
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			SpawnEnemy();
			gameObject.SetActive(false);
		}
	}
}
