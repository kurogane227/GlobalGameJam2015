using UnityEngine;
using System.Collections;

public class UIPanel_Title : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public void OnStartButtonPressed()
	{
		UIManager.Instance.titleScreenPage.SetActive(false);
		UIManager.Instance.LoadLevel("levelScene");
	}
	
	public void OnCreditsButtonPressed()
	{
		UIManager.Instance.creditsScreenPage.SetActive(true);
		UIManager.Instance.titleScreenPage.SetActive(false);
	}
}
