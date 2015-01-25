using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	
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
		if (Input.GetKeyDown(KeyCode.E))
		{
			ShowEventBox("B", 15);
		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			UpdatePowerBar(1, HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount + 0.1f);
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
	
	public void LoadHUD()
	{
		// Load the main menu UI
		HUDObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/HUD")) as GameObject;
		HUDScript = (UIPanel_HUD)HUDObject.GetComponentInChildren<UIPanel_HUD>() as UIPanel_HUD;
	}

	public void UpdatePowerBar(int playerNum, float powerAmount)
	{
		if(HUDScript != null)
		{
			if (playerNum == 1)
			{
				if (!HUDScript.player1HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
				}
			}
			else if (playerNum == 2)
			{
				if (!HUDScript.player2HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
				}
			}
			else if (playerNum == 3)
			{
				if (!HUDScript.player3HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
				}
			}
			else
			{
				if (!HUDScript.player4HUD.GetComponent<UIPlayerHUD>().isOverheated)
				{
					HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
				}
			}
		}
	}

	public void PlayHitReaction(int playerNum)
	{
		if (HUDScript != null)
		{
			if (playerNum == 1)
			{
				HUDScript.player1HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else if (playerNum == 2)
			{
				HUDScript.player2HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else if (playerNum == 3)
			{
				HUDScript.player3HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else if (playerNum == 4)
			{
				HUDScript.player4HUD.GetComponent<UIPlayerHUD>().alienPicture.animation.Play("pictureShake");
			}
			else
			{
				Debug.Log("Did not specify a player for hit reaction...");
			}
		}
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
	
//	public GameObject ResultsObject = null;
//	public UIResults ResultsScript = null;
//	
//	public void LoadResults()
//	{
//		// Load the main menu UI
//		ResultsObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/Results")) as GameObject;
//		ResultsScript = (UIResults)ResultsObject.GetComponent<UIResults>() as UIResults;
//	}


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
