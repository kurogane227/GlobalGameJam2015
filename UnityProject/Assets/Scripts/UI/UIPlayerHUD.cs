using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIPlayerHUD : MonoBehaviour {

	public Image powerFill;
	public GameObject overheatObject;
	public bool isOverheated = false;

	// Use this for initialization
	void Start ()
	{
		overheatObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (powerFill.fillAmount >= 1.0f && !isOverheated)
		{
			// Overheated
			isOverheated = true;
			overheatObject.SetActive(true);
		}
	}

	public IEnumerator Cooldown()
	{
		yield return new WaitForSeconds(4.0f);

		// Now you've cooled down
		powerFill.fillAmount = 0.0f;
		isOverheated = false;
	}
}
