using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

	public float thrust_1;
	public float thrust_2;
	public string cheatThrust;
	public float desiredThrust;

	
	private float previousThrust;
	private float currentPowerPercentage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

		desiredThrust = thrust_1 + thrust_2;

		if (Input.GetButton (cheatThrust))
		{
			desiredThrust += 1.5f;
		}

		if (desiredThrust != previousThrust) 
		{

			float difference = desiredThrust - previousThrust;
			if (Mathf.Abs(difference) < 0.05f)
			{
				previousThrust = desiredThrust;
			}

			float actualThrust;

			if (desiredThrust >= previousThrust)
			{
				actualThrust = previousThrust + ((desiredThrust - previousThrust) * Time.deltaTime * 1f);
			}
			else
			{
				actualThrust = previousThrust + ((desiredThrust - previousThrust) * Time.deltaTime * 1.5f);
			}

			currentPowerPercentage = actualThrust / 2f;
			GetComponentInChildren<ParticleSystem>().transform.localScale = new Vector3(currentPowerPercentage, currentPowerPercentage, currentPowerPercentage);

			// 1 * 0.002

			//print (thrust_1 + "   " + thrust_2 + "    " + totalThrust);
			//GetComponentInParent<Rigidbody> ().AddForceAtPosition (new Vector3 (0, 0, totalThrust), this.transform.position);
			previousThrust = actualThrust;
		}
		transform.parent.GetComponentInParent<Rigidbody> ().AddForce (this.transform.forward * previousThrust * 7.5f);


	}
}
