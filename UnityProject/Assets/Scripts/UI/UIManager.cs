using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	
	private float doubleSpeed = 0.006f;
	private float singleSpeed = 0.003f;
	private float brakeSpeed = -0.003f;
	
	private static UIManager instance = null;
	public static UIManager Instance
	{
		get { return instance; }
	}
	
	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			instance.LoadTitleScreen();
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Use this for initialization
	void Start ()
	{
		LoadTitleScreen();
	}

	void Update()
	{
		//Input handling for UI
		if (HUDScript != null)
		{
			//==========================|
			// DEBUG CONTROLS
			//==========================|
			if (Input.GetKeyDown(KeyCode.E) && HUDScript != null)
			{
				ShowEventBox("B", 15);
			}
			
			if (Input.GetKeyDown(KeyCode.R) && HUDScript != null)
			{
				LoadResults();
			}
			
			if (Input.GetKeyDown(KeyCode.I) && HUDScript != null)
			{
				PlayAllHitReaction();
			}
//
//			if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A) && HUDScript != null) // Both triggers held down
//			{
//				if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
//				{
//					UpdatePowerBar(1, doubleSpeed);
//				}
//			}
//			else if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) && HUDScript != null) // one trigger is held down
//			{
//				if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
//				{
//					UpdatePowerBar(1, singleSpeed);
//				}
//			}
//			else
//			{
//				if (HUDScript != null)
//				{
//					if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount > 0.0f)
//					{
//						UpdatePowerBar(1, brakeSpeed);
//					}
//				}
//			}
			
			//==================================================================================================|
			// REAL CONTROLS
			//==================================================================================================|
			
			//==========================|
			// PLAYER 1
			//==========================|
			if (InputManager.pl_Controller.leftTrigger > 0.0f && InputManager.pl_Controller.rightTrigger > 0.0f && HUDScript != null) // Both triggers held down
			{
				if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(1, doubleSpeed);
				}
			}
			else if (InputManager.pl_Controller.leftTrigger > 0.0f || InputManager.pl_Controller.rightTrigger > 0.0f && HUDScript != null) // one trigger is held down
			{
				if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(1, singleSpeed);
				}
			}
			else
			{
				if (HUDScript != null)
				{
					if (HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount > 0.0f)
					{
						UpdatePowerBar(1, brakeSpeed);
					}
				}
			}
			
			//==========================|
			// PLAYER 2
			//==========================|
			if (InputManager.p2_Controller.leftTrigger > 0.0f && InputManager.p2_Controller.rightTrigger > 0.0f && HUDScript != null) // Both triggers held down
			{
				if (HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(2, doubleSpeed);
				}
			}
			else if (InputManager.p2_Controller.leftTrigger > 0.0f || InputManager.p2_Controller.rightTrigger > 0.0f && HUDScript != null) // one trigger is held down
			{
				if (HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(2, singleSpeed);
				}
			}
			else
			{
				if (HUDScript != null)
				{
					if (HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount > 0.0f)
					{
						UpdatePowerBar(2, brakeSpeed);
					}
				}
			}
			
			//==========================|
			// PLAYER 3
			//==========================|
			if (InputManager.p3_Controller.leftTrigger > 0.0f && InputManager.p3_Controller.rightTrigger > 0.0f && HUDScript != null) // Both triggers held down
			{
				if (HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(3, doubleSpeed);
				}
			}
			else if (InputManager.p3_Controller.leftTrigger > 0.0f || InputManager.p3_Controller.rightTrigger > 0.0f && HUDScript != null) // one trigger is held down
			{
				if (HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(3, singleSpeed);
				}
			}
			else
			{
				if (HUDScript != null)
				{
					if (HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount > 0.0f)
					{
						UpdatePowerBar(3, brakeSpeed);
					}
				}
			}
			
			//==========================|
			// PLAYER 4
			//==========================|
			if (InputManager.p4_Controller.leftTrigger > 0.0f && InputManager.p4_Controller.rightTrigger > 0.0f && HUDScript != null) // Both triggers held down
			{
				if (HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(4, doubleSpeed);
				}
			}
			else if (InputManager.p4_Controller.leftTrigger > 0.0f || InputManager.p4_Controller.rightTrigger > 0.0f && HUDScript != null) // one trigger is held down
			{
				if (HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount < 1.0f)
				{
					UpdatePowerBar(4, singleSpeed);
				}
			}
			else
			{
				if (HUDScript != null)
				{
					if (HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount > 0.0f)
					{
						UpdatePowerBar(4, brakeSpeed);
					}
				}
			}
		}
	}

	//==================================================================================================|
	// TITLE SCREEN
	//==================================================================================================|
	public GameObject titleScreenObject = null;
	public UIPanel_Title titleScreenScript = null;
	public GameObject titleScreenPage = null;
	public GameObject creditsScreenPage = null;
	
	public void LoadTitleScreen()
	{
		// Load the main menu UI
		titleScreenObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/MainMenu")) as GameObject;
		titleScreenScript = (UIPanel_Title)titleScreenObject.GetComponentInChildren<UIPanel_Title>() as UIPanel_Title;
		
		// Turn the proper pages on/off
		titleScreenPage = titleScreenScript.gameObject;
		titleScreenPage.SetActive(true);
		creditsScreenPage = titleScreenObject.GetComponentInChildren<UIPanel_Credits>().gameObject;
		creditsScreenPage.SetActive(false);
	}


	//==================================================================================================|
	// HUD
	//==================================================================================================|
	public GameObject HUDObject = null;
	public UIPanel_HUD HUDScript = null;
	
	public bool disablePlayer1Input = false;
	public bool disablePlayer2Input = false;
	public bool disablePlayer3Input = false;
	public bool disablePlayer4Input = false;
	
	public void LoadHUD()
	{
		// Load the main menu UI
		HUDObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/HUD")) as GameObject;
		HUDScript = (UIPanel_HUD)HUDObject.GetComponentInChildren<UIPanel_HUD>() as UIPanel_HUD;
	}
	
	public void DestroyHUD()
	{
		if (HUDObject != null)
		{
			Destroy(HUDObject);
			HUDObject = null;
			HUDScript = null;
		}
	}
	
	public void UpdatePowerBar(int playerNum, float powerAmount)
	{
		if(HUDScript != null)
		{
			if (playerNum == 1)
			{
				if (!HUDScript.player1HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount += powerAmount;
				}
			}
			else if (playerNum == 2)
			{
				if (!HUDScript.player2HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount += powerAmount;
				}
			}
			else if (playerNum == 3)
			{
				if (!HUDScript.player3HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount += powerAmount;
				}
			}
			else
			{
				if (!HUDScript.player4HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount += powerAmount;
				}
			}
		}
	}

	public void PlaySingleReaction(int playerNum)
	{
		if (HUDScript != null)
		{
			if (playerNum == 1)
			{
				HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
				HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else if (playerNum == 2)
			{
				HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
				HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else if (playerNum == 3)
			{
				HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
				HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake2");
			}
			else if (playerNum == 4)
			{
				HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
				HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake2");
			}
			else
			{
				Debug.Log("Did not specify a player for hit reaction...");
			}
			
			StartCoroutine(DelayedResetAlienPictures());
		}
	}
	
	public void PlayAllHitReaction()
	{
		if (HUDScript != null)
		{
			HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
			HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
			HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
			HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(true);
		
			HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake2");
			HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake2");
			
			StartCoroutine(DelayedResetAlienPictures());
		}
	}
	
	public IEnumerator DelayedResetAlienPictures()
	{
		yield return new WaitForSeconds(1.5f);
		
		HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(false);
		HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(false);
		HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(false);
		HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienALTPicture.SetActive(false);
	}

	public void ShowEventBox(string buttonLetter = "X", int numTimesToPress = 10)
	{
		if (HUDScript != null)
		{
			HUDScript.eventObject.SetActive(true);
			HUDScript.eventObject.GetComponent<UIEvent>().eventText.text = "Press " + buttonLetter + "\n" + numTimesToPress + " times!";
			ShowButtonPrompt(buttonLetter);
			UpdateEventCount(0);
		}
	}

	public void HideEventBox()
	{
		HUDScript.eventObject.SetActive(false);
	}

	public void UpdateEventCount(int countNum)
	{
		if (HUDScript != null)
		{
			HUDScript.eventObject.GetComponent<UIEvent>().countText.text = countNum.ToString();
		}
	}

	public void ShowButtonPrompt(string button)
	{
		if(HUDScript != null)
		{
			HideButtonPrompt();

			if (button == "A")
			{
				// Show the X button
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA.animation.Play("buttonPulse");
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA2.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA2.animation.Play("buttonPulse");
			}
			else if (button == "B")
			{
				// Show the A button
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB.animation.Play("buttonPulse");
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB2.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB2.animation.Play("buttonPulse");
			}
			else if (button == "X")
			{
				// Show the B button
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX.animation.Play("buttonPulse");
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX2.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX2.animation.Play("buttonPulse");
			}
			else if (button == "Y")
			{
				// Show the Y button
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY.animation.Play("buttonPulse");
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY2.SetActive(true);
				HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY2.animation.Play("buttonPulse");
			}
			else
			{
				Debug.Log("This event does not have a button letter associated with it.");
			}
		}
	}

	public void HideButtonPrompt()
	{
		if (HUDScript != null)
		{
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY.SetActive(false);

			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageA2.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageB2.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageX2.SetActive(false);
			HUDScript.eventObject.GetComponent<UIEvent>().buttonImageY2.SetActive(false);
		}
	}
	
	public GameObject ResultsObject = null;
	public UIPanel_Results ResultsScript = null;
	
	public void LoadResults()
	{
		// Load the main menu UI
		ResultsObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/Results")) as GameObject;
		ResultsScript = (UIPanel_Results)ResultsObject.GetComponent<UIPanel_Results>() as UIPanel_Results;
		
		DestroyHUD();
	}
	
	public void DestroyResults()
	{
		if (ResultsObject != null)
		{
			Destroy(ResultsObject);
			ResultsObject = null;
			ResultsScript = null;
		}
	}


	//==================================================================================================|
	// LEVEL LOAD
	//==================================================================================================|
	public void LoadLevel(string levelSceneName)
	{
		Debug.Log ("Load Level here...");
		Application.LoadLevel(levelSceneName);

		StartCoroutine(WaitToLoadHUD());
	}

	public IEnumerator WaitToLoadHUD()
	{
		yield return new WaitForSeconds(0.01f);
		LoadHUD();
	}
}
