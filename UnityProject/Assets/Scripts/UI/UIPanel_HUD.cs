using UnityEngine;
using System.Collections;

public class UIPanel_HUD : MonoBehaviour {

	public GameObject player1HUD = null;
	public GameObject player2HUD = null;
	public GameObject player3HUD = null;
	public GameObject player4HUD = null;

	public GameObject player1Reticle = null;
	public GameObject player2Reticle = null;
	public GameObject player3Reticle = null;
	public GameObject player4Reticle = null;

	// Use this for initialization
	void Start ()
	{
		// Make reticles invisible at the start
		player1Reticle.SetActive(false);
		player2Reticle.SetActive(false);
		player3Reticle.SetActive(false);
		player4Reticle.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (player1Reticle.activeSelf)
		{
			// Update this reticle
			//player1Reticle.transform.position = ProjectToScreenSpace();
		}
	}

	protected Vector3 ProjectToScreenSpace( Vector3 Position )
	{
		// When using this function, the returned position will be in UI world space
		// so set transform.position and NOT transform.localPosition

		// Get position with perspective
		//Vector3 screenPos = LevelManager.Me.ActiveCamera.WorldToScreenPoint(Position);
		
		// Convert the perspective to ortho
		//screenPos = HUDCamera.ScreenToWorldPoint(screenPos);
		
		//screenPos = new Vector3( screenPos.x, screenPos.y, 0.0f );
		
		//return screenPos;
		return Vector3.zero;
	}

	public void TurnOnReticle(int playerNum)
	{
		if(playerNum == 1)
		{
			player1Reticle.SetActive(true);
		}
		else if (playerNum == 2)
		{
			player2Reticle.SetActive(true);
		}
		else if (playerNum == 2)
		{
			player3Reticle.SetActive(true);
		}
		else if (playerNum == 2)
		{
			player4Reticle.SetActive(true);
		}
		else
		{
			Debug.Log("Error: Used wrong number when requesting to turn on reticle...");
		}
	}
}
