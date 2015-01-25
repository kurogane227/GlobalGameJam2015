using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {


	private static SoundManager instance = null;
	public static SoundManager Instance
	{
		get { return instance; }
	}

	public AudioClip childrenHooray1 = null;
	public AudioClip childrenHooray2 = null;
	public AudioClip childrenHooray3 = null;

	public AudioClip childrenSad1 = null;
	public AudioClip childrenSad2 = null;
	public AudioClip childrenSad3 = null;

	public AudioClip miltonGreetingSuccess1 = null;
	public AudioClip miltonGreetingSuccess2 = null;
	public AudioClip miltonGreetingSuccess3 = null;

	public AudioClip miltonGreetingFail1 = null;
	public AudioClip miltonGreetingFail2 = null;
	public AudioClip miltonGreetingFail3 = null;

	public AudioClip ambientRocketBoosterLight = null;
	public AudioClip ambientRocketBoosterMedium = null;
	public AudioClip ambientRocketBoosterHeavy = null;
	public AudioClip ambientRocketBoosterSuperHeavy = null;

	public AudioClip collisionBounce1 = null;
	public AudioClip collisionBounce2 = null;
	public AudioClip collisionBounce3 = null;

	public AudioClip collisionRough1 = null;
	public AudioClip collisionRough2 = null;
	public AudioClip collisionRough3 = null;

	public AudioClip collisionSmack1 = null;
	public AudioClip collisionSmack2 = null;
	public AudioClip collisionSmack3 = null;

	public AudioClip shortCircuit = null;

	public AudioClip fanfare = null;
	public AudioClip boo = null;

	public AudioClip player1Scream = null;
	public AudioClip player2Scream = null;
	public AudioClip player3Scream = null;
	public AudioClip player4Scream = null;

	public AudioClip ambientRollerCoaster = null;
	public AudioClip ambientAudio = null;

	// Use this for initialization
	void Awake () {
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
