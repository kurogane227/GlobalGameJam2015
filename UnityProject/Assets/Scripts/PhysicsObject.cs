using UnityEngine;
using System.Collections;

public class PhysicsObject : MonoBehaviour {

	public Collider myCollider = null;


	// Use this for initialization
	void Start () {
		if(myCollider!=null){
			myCollider.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player"){
			rigidbody.useGravity = true;
			myCollider.enabled = true;
		}
	}
}
