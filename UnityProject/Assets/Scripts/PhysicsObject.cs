using UnityEngine;
using System.Collections;

public class PhysicsObject : MonoBehaviour {

	public Collider myCollider = null;


	public enum collisionSound{
		rough, bouncy, smack
	};

	public collisionSound soundTypeGenerated;

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
			UIManager.Instance.PlayAllHitReaction();

			if(soundTypeGenerated != null){
				if(soundTypeGenerated == collisionSound.bouncy){
					SoundManager.Instance.PlayBouncyClip();
				}
				else if(soundTypeGenerated == collisionSound.rough){
					SoundManager.Instance.PlayRoughClip();
				}
				else{
					SoundManager.Instance.PlaySmackClip();
				}
			}
		}
	}
}
