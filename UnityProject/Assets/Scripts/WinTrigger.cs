using UnityEngine;
using System.Collections;

public class WinTrigger : MonoBehaviour {
	
	void OnTriggerEnter (Collider other) {
		if(other.gameObject.tag == "Player"){
			UIManager.Instance.LoadResults();
			AudioSource.PlayClipAtPoint( );
	}
	}
}