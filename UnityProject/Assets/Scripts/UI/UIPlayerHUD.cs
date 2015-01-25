using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIPlayerHUD : MonoBehaviour {

	public Image powerFill;
	public GameObject overheatObject;
	public bool isOverheated = false;
	public GameObject alienPicture;

	// Use this for initialization
	void Start ()
	{
		powerFill.fillAmount = 0.0f;
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
			// TODO: Figure out why animation is not working
			overheatObject.animation.Play("overheat");
			alienPicture.animation.Play("pictureShake");
			StartCoroutine(Cooldown());
		}
	}

	public IEnumerator Cooldown()
	{
		yield return new WaitForSeconds(4.0f);

		Debug.Log("COOLED DOWN");

		// Now you've cooled down
		powerFill.fillAmount = 0.0f;
		isOverheated = false;
		overheatObject.SetActive(false);
	}
}
