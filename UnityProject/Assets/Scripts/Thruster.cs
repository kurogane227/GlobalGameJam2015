using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

	public float thrust_1;
	public float thrust_2;
	public float totalThrust;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		totalThrust = thrust_1 + thrust_2;
	}
}
