using UnityEngine;
using System.Collections;

public class UIPanel_HUD : MonoBehaviour {

	public GameObject player1HUD;
	public GameObject player2HUD;
	public GameObject player3HUD;
	public GameObject player4HUD;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
}
