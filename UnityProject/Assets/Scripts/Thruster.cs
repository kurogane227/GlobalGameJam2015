using UnityEngine;
using System.Collections;

public class Thruster : MonoBehaviour {

	public float thrust_1;
	public float thrust_2;
	public string cheatThrust;
	public float desiredThrust;
	
	[HideInInspector]
	public int leftTriggerIndex;
	[HideInInspector]
	public int rightTriggerIndex;
	
	public ParticleSystem leftTriggerFX;
	public ParticleSystem rightTriggerFX;

	
	private float previousThrust;
	//private float currentPowerPercentage;
	
	private float particleGrowthRate = 0.9f;
	private float maxParticleScale = 0.4f;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{


		if (Input.GetButton (cheatThrust))
		{
			thrust_1 = 0.75f;
			thrust_2 = 0.75f;
		}
		desiredThrust = thrust_1 + thrust_2;

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
				actualThrust = previousThrust + ((desiredThrust - previousThrust) * Time.deltaTime * 2.5f);
			}
			else
			{
				actualThrust = previousThrust + ((desiredThrust - previousThrust) * Time.deltaTime * 3f);
			}

			
			previousThrust = actualThrust;
		}
		
		Transform particleTransform = GetComponentInChildren<SphereCollider>().transform;
		
		UpdateFXScale(particleTransform);
		UpdateParticleScale();
		transform.parent.parent.parent.parent.GetComponentInParent<Rigidbody> ().AddForce (-this.transform.forward * previousThrust * 10f);
		

	}
	
	public void UpdateFXScale(Transform particleTransform)
	{
		float desiredParticleScale = (desiredThrust / 2);
		desiredParticleScale *= 0.4f;
		
		if (particleTransform.localScale.x < desiredParticleScale)
		{
			float newScale = particleTransform.localScale.x + (Time.deltaTime * particleGrowthRate);
			newScale = Mathf.Clamp(newScale, 0f, desiredParticleScale);
			
			particleTransform.localScale = new Vector3(newScale, newScale, newScale);
			//particleTransform.localScale = new Vector3(newScale, newScale, newScale);
			GetComponentInChildren<Light>().range = newScale * 25f;
		}
		else if (particleTransform.localScale.x > desiredParticleScale)
		{
			float newScale = particleTransform.localScale.x - (Time.deltaTime * particleGrowthRate);
			newScale = Mathf.Clamp(newScale, desiredParticleScale, maxParticleScale); 
			particleTransform.localScale = new Vector3(newScale, newScale, newScale);
			GetComponentInChildren<Light>().range = newScale * 25f;
		}
	}
	
	public void UpdateParticleScale()
	{
		float desiredLeftEmissionRate = thrust_1 * 8f;
		float desiredRightEmissionRate = thrust_2 * 8f;
		
		leftTriggerFX.emissionRate = desiredLeftEmissionRate;
		rightTriggerFX.emissionRate = desiredRightEmissionRate;
		leftTriggerFX.startSpeed = thrust_1 + 0.25f;
		rightTriggerFX.startSpeed = thrust_2 + 0.25f;
		
		if (leftTriggerIndex == 0)
			leftTriggerFX.startColor = Color.blue;
		else if (leftTriggerIndex == 1)
			leftTriggerFX.startColor = Color.yellow;
		else if (leftTriggerIndex == 2)
			leftTriggerFX.startColor = Color.green;
		else if (leftTriggerIndex == 3)
			leftTriggerFX.startColor = Color.red;
		
		
		if (rightTriggerIndex == 0)
			rightTriggerFX.startColor = Color.blue;
		else if (rightTriggerIndex == 1)
			rightTriggerFX.startColor = Color.yellow;
		else if (rightTriggerIndex == 2)
			rightTriggerFX.startColor = Color.green;
		else if (rightTriggerIndex == 3)
			rightTriggerFX.startColor = Color.red;
	}
}
