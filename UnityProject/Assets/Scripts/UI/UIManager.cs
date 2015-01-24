using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {
	
	public bool timeIsStillTicking = true;
	public string cardType = "blosser";
	
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
		HUDScript = (UIPanel_HUD)HUDObject.GetComponent<UIPanel_HUD>() as UIPanel_HUD;
	}

	public void UpdatePowerBar(int playerNum, float powerAmount)
	{
		if(HUDScript != null)
		{
			if (playerNum == 1)
			{
				HUDScript.player1HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
			}
			else if (playerNum == 2)
			{
				HUDScript.player2HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
			}
			else if (playerNum == 3)
			{
				HUDScript.player3HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
			}
			else
			{
				HUDScript.player4HUD.GetComponent<UIPlayerHUD>().powerFill.fillAmount = powerAmount;
			}
		}
	}

	public void ShowButtonPrompt(string button)
	{
		if(HUDScript != null)
		{
			HideButtonPrompt();

			if (button == "a")
			{
				// Show the X button
				HUDScript.GetComponentInChildren<UIEvent>().buttonImageA.SetActive(false);
			}
			else if (button == "b")
			{
				// Show the A button
				HUDScript.GetComponentInChildren<UIEvent>().buttonImageB.SetActive(false);
			}
			else if (button == "x")
			{
				// Show the B button
				HUDScript.GetComponentInChildren<UIEvent>().buttonImageX.SetActive(false);
			}
			else if (button == "y")
			{
				// Show the Y button
				HUDScript.GetComponentInChildren<UIEvent>().buttonImageY.SetActive(false);
			}
			else
			{
				Debug.Log("Error: You did not send the correct button to ShowButtonPrompt");
			}
		}
	}

	public void HideButtonPrompt()
	{
		if (HUDScript != null)
		{
			HUDScript.GetComponentInChildren<UIEvent>().buttonImageA.SetActive(false);
			HUDScript.GetComponentInChildren<UIEvent>().buttonImageB.SetActive(false);
			HUDScript.GetComponentInChildren<UIEvent>().buttonImageX.SetActive(false);
			HUDScript.GetComponentInChildren<UIEvent>().buttonImageY.SetActive(false);
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
		//Application.LoadLevel(levelSceneName);
	}
}
