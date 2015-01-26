using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

	public Enemy enemy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(!enemy.dead)
			transform.LookAt(Camera.main.transform.position);
	
	}
}
