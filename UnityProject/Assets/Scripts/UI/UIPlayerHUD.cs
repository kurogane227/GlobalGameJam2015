using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIPlayerHUD : MonoBehaviour {

	public Image powerFill;

	// Use this for initialization
	void Start ()
	{
		powerFill.fillAmount = 0.5f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
