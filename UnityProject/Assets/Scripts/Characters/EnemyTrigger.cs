using UnityEngine;
using System.Collections;

public class EnemyTrigger : MonoBehaviour 
{
	public GameObject player;
	public bool engage =false;
	public bool exit = false;
	public Vector3 exitPos;
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other)
	{
		if (other == player.collider) 
		{
			engage = true;
		};
	}
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
}
