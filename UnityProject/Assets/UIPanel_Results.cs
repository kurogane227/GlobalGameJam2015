using UnityEngine;
using System.Collections;

public class UIPanel_Results : MonoBehaviour {

	public GameObject failBackground;

	// Use this for initialization
	void Start ()
	{
		if (UIManager.Instance.didWeWin)
		{
			failBackground.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	
	public void OnBackButtonPressed()
	{
		Application.LoadLevel("mainScene");
	}
}
