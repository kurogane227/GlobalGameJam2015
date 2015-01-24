using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIEvent : MonoBehaviour {
	
	public Text eventText = null;
	public Text countText = null;

	public GameObject buttonImageA = null;
	public GameObject buttonImageA2 = null;
	public GameObject buttonImageB = null;
	public GameObject buttonImageB2 = null;
	public GameObject buttonImageX = null;
	public GameObject buttonImageX2 = null;
	public GameObject buttonImageY = null;
	public GameObject buttonImageY2 = null;

	// Use this for initialization
	void Start ()
	{
		this.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
