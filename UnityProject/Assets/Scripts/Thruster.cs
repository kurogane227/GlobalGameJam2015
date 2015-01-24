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
		if (totalThrust > 0)
		{
			//print (thrust_1 + "   " + thrust_2 + "    " + totalThrust);
			//GetComponentInParent<Rigidbody> ().AddForceAtPosition (new Vector3 (0, 0, totalThrust), this.transform.position);
			GetComponentInParent<Rigidbody>().AddForce(this.transform.forward * totalThrust * 2);
		}
	}
}
