using UnityEngine;
using System.Collections;

public class lockPosToParent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		UpdatePositionAndRotation ();
	}

	void UpdatePositionAndRotation(){
		Transform parent = gameObject.transform.parent;
		//this.gameObject.transform = parent.transform;
		//bacino.position = new Vector3(0,0,0);
		this.gameObject.transform.position = new Vector3(parent.position.x, parent.position.y+1f, parent.position.z);
	}
}
