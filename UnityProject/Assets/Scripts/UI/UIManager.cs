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

	public void ShowEventBox(string eventText, string buttonLetter = "")
	{
		if (HUDScript != null)
		{
			HUDScript.GetComponentInChildren<UIEvent>().gameObject.SetActive(true);

			HUDScript.GetComponentInChildren<UIEvent>().eventText.text = eventText;
			ShowButtonPrompt(buttonLetter);
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
				Debug.Log("This event does not have a button letter associated with it.");
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
		Application.LoadLevel(levelSceneName);

		StartCoroutine(WaitToLoadHUD());
	}

	public IEnumerator WaitToLoadHUD()
	{
		yield return new WaitForSeconds(0.1f);
		LoadHUD();
	}
}
