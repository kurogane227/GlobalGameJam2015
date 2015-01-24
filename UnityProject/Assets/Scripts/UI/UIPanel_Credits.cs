using UnityEngine;
using System.Collections;

public class UIPanel_Credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void OnBackButtonPressed()
	{
		UIManager.Instance.titleScreenPage.SetActive(true);
		UIManager.Instance.creditsScreenPage.SetActive(false);
	}
}
