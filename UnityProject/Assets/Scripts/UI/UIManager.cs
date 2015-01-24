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
	
	public GameObject HUDObject = null;
//	public UIHUD_Events HUDScript = null;
//	
//	public void LoadHUD()
//	{
//		// Load the main menu UI
//		HUDObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/HUD")) as GameObject;
//		HUDScript = (UIHUD_Events)HUDObject.GetComponent<UIHUD_Events>() as UIHUD_Events;
//	}
//	
//	public GameObject ResultsObject = null;
//	public UIResults ResultsScript = null;
//	
//	public void LoadResults()
//	{
//		// Load the main menu UI
//		ResultsObject = GameObject.Instantiate(Resources.Load ("UI/Prefabs/Results")) as GameObject;
//		ResultsScript = (UIResults)ResultsObject.GetComponent<UIResults>() as UIResults;
//	}
	
	public void LoadLevel(string levelSceneName)
	{
		Debug.Log ("Load Level here...");
		//Application.LoadLevel(levelSceneName);
	}
}
