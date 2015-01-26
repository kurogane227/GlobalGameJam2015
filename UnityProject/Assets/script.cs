using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if(other.tag == "Player"){
			UIManager.Instance.didWeWin = true;
			UIManager.Instance.LoadResults();
			SoundManager.Instance.PlayEndGame();
		}
	}
}
