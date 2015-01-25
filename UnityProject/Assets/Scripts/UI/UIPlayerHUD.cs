using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIPlayerHUD : MonoBehaviour {
	
	public int myNumber = 0;
	private int reenableNum = 0;

	public Image powerFill;
	public GameObject overheatObject;
	public bool isOverheated = false;
	public GameObject alienPicture;
	public GameObject alienALTPicture;
	
	public GameObject leftTriggerGreen;
	public GameObject leftTriggerRed;
	public GameObject leftTriggerBlue;
	public GameObject leftTriggerYellow;
	
	public GameObject rightTriggerGreen;
	public GameObject rightTriggerRed;
	public GameObject rightTriggerBlue;
	public GameObject rightTriggerYellow;

	// Use this for initialization
	void Start ()
	{
		powerFill.fillAmount = 0.0f;
		overheatObject.SetActive(false);
		alienALTPicture.SetActive(false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (powerFill.fillAmount >= 1.0f && !isOverheated)
		{
			// Disable controls for this player for a bit
			if (myNumber == 1)
				UIManager.Instance.disablePlayer1Input = true;
			else if (myNumber == 2)
				UIManager.Instance.disablePlayer2Input = true;
			else if (myNumber == 3)
				UIManager.Instance.disablePlayer3Input = true;
			else if (myNumber == 4)
				UIManager.Instance.disablePlayer4Input = true;
			else
				Debug.Log("Didn't provide a proper number in UIPlayerHUD");
			
			reenableNum = myNumber;
		
			// Overheated
			isOverheated = true;
			overheatObject.SetActive(true);
			// TODO: Figure out why animation is not working
			overheatObject.animation.Play("overheat");
			CharacterShake(3.0f);
			StartCoroutine(Cooldown(reenableNum));
		}
	}

	public void CharacterShake(float timeToShake)
	{
		alienALTPicture.SetActive(true);
		if (myNumber == 1 || myNumber == 2)
			alienPicture.animation.Play("pictureShake");
		else
			alienPicture.animation.Play("pictureShake2");
			
		StartCoroutine(RestoreCharacterPicture(timeToShake));
	}

	public IEnumerator Cooldown(int numberToRevive)
	{
		yield return new WaitForSeconds(3.0f);

		Debug.Log("COOLED DOWN");
		
		if (numberToRevive == 1)
			UIManager.Instance.disablePlayer1Input = false;
		else if (numberToRevive == 2)
			UIManager.Instance.disablePlayer2Input = false;
		else if (numberToRevive == 3)
			UIManager.Instance.disablePlayer3Input = false;
		else if (numberToRevive == 4)
			UIManager.Instance.disablePlayer4Input = false;
		else
			Debug.Log("Didn't provide a proper IN COOLDOWN number of UIPlayerHUD");

		// Now you've cooled down
		alienALTPicture.SetActive(false);
		powerFill.fillAmount = 0.0f;
		isOverheated = false;
		overheatObject.SetActive(false);
	}
	
	public IEnumerator RestoreCharacterPicture(float timeToDelay)
	{
		yield return new WaitForSeconds(timeToDelay);
		
		Debug.Log("COOLED DOWN");
		
		alienALTPicture.SetActive(false);
	}
	
	public void SetNewTriggerPanels(string leftTriggerColor, string rightTriggerColor)
	{
		// Front = Red, Right = Green, Back = Blue, Left = Yellow
	
//		HideAllTriggerPanels();
//		
//		if (leftTriggerColor == "green")
//		{
//			leftTriggerGreen.SetActive(true);
//		}
//		else if (leftTriggerColor == "red")
//		{
//			leftTriggerRed.SetActive(true);
//		}
//		else if (leftTriggerColor == "blue")
//		{
//			leftTriggerBlue.SetActive(true);
//		}
//		else if (leftTriggerColor == "yellow")
//		{
//			leftTriggerYellow.SetActive(true);
//		}
//		else
//		{
//			Debug.Log("INCORRECT COLOR GIVEN TO LEFT TRIGGER");
//		}
//		
//		if (rightTriggerColor == "green")
//		{
//			rightTriggerGreen.SetActive(true);
//		}
//		else if (rightTriggerColor == "red")
//		{
//			rightTriggerRed.SetActive(true);
//		}
//		else if (rightTriggerColor == "blue")
//		{
//			rightTriggerBlue.SetActive(true);
//		}
//		else if (rightTriggerColor == "yellow")
//		{
//			rightTriggerYellow.SetActive(true);
//		}
//		else
//		{
//			Debug.Log("INCORRECT COLOR GIVEN TO RIGHT TRIGGER");
//		}
	}
	
	public void HideAllTriggerPanels()
	{
//		leftTriggerGreen.SetActive(false);
//		leftTriggerRed.SetActive(false);
//		leftTriggerBlue.SetActive(false);
//		leftTriggerYellow.SetActive(false);
//		
//		rightTriggerGreen.SetActive(false);
//		rightTriggerRed.SetActive(false);
//		rightTriggerBlue.SetActive(false);
//		rightTriggerYellow.SetActive(false);
	}
}
