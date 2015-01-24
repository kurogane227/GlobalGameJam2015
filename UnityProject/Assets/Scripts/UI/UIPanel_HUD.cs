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

	private bool usePlayer1Reticle = false;
	private bool usePlayer2Reticle = false;
	private bool usePlayer3Reticle = false;
	private bool usePlayer4Reticle = false;

	public GameObject eventObject = null;

	private Camera thisMainCamera = null;
	private GameObject objectToAttachTo = null;
	public GameObject canvasObject = null;

	// Use this for initialization
	void Start ()
	{
		// Make reticles invisible at the start
		player1Reticle.SetActive(false);
		player2Reticle.SetActive(false);
		player3Reticle.SetActive(false);
		player4Reticle.SetActive(false);

		thisMainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
		objectToAttachTo = GameObject.Find("CATRig_Head");
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Determine if the reticles should be visible and attached
		if (player1Reticle.activeSelf)
			usePlayer1Reticle = true;
		else
			usePlayer1Reticle = false;

		if (player1Reticle.activeSelf)
			usePlayer1Reticle = true;
		else
			usePlayer1Reticle = false;

		if (player1Reticle.activeSelf)
			usePlayer1Reticle = true;
		else
			usePlayer1Reticle = false;

		if (player1Reticle.activeSelf)
			usePlayer1Reticle = true;
		else
			usePlayer1Reticle = false;

		if (usePlayer1Reticle)
			player1Reticle.GetComponent<RectTransform>().anchoredPosition = ProjectToScreenSpace(objectToAttachTo);

		//DEBUG, TODO: REMOVE THIS
		if (Input.GetKeyDown(KeyCode.R))
		{
			player1Reticle.SetActive(true);
			player1Reticle.GetComponent<RectTransform>().anchoredPosition = ProjectToScreenSpace(objectToAttachTo);
		}
	}

	protected Vector2 ProjectToScreenSpace(GameObject attachToThisObject)
	{			
		//first you need the RectTransform component of your canvas
		RectTransform CanvasRect = canvasObject.GetComponent<RectTransform>();
		
		//then you calculate the position of the UI element
		//0,0 for the canvas is at the center of the screen, whereas WorldToViewPortPoint treats the lower left corner as 0,0. Because of this, you need to subtract the height / width of the canvas * 0.5 to get the correct position.
		
		Vector2 ViewportPosition = thisMainCamera.WorldToViewportPoint(attachToThisObject.transform.position);
		Vector2 attachToThisObject_ScreenPosition = new Vector2(
			((ViewportPosition.x*CanvasRect.sizeDelta.x)-(CanvasRect.sizeDelta.x*0.5f)),
			((ViewportPosition.y*CanvasRect.sizeDelta.y)-(CanvasRect.sizeDelta.y*0.5f)));
		
		//now you can set the position of the ui element
		return (attachToThisObject_ScreenPosition);
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
