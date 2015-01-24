using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotController : MonoBehaviour {

	public List<Thruster> leftThrusterAssignment;
	public List<Thruster> rightThrusterAssignment;

	public Thruster frontThruster;
	public Thruster backThruster;
	public Thruster leftThruster;
	public Thruster rightThruster;

	// Use this for initialization
	void Start ()
	{
		leftThrusterAssignment = new List<Thruster>();
		rightThrusterAssignment = new List<Thruster>();
		AssignInitialThrusters ();

		print ("lt 1 = " + leftThrusterAssignment [0].gameObject.name);
		print ("lt 2 = " + leftThrusterAssignment [1].gameObject.name);
		print ("lt 3 = " + leftThrusterAssignment [2].gameObject.name);
		print ("lt 4 = " + leftThrusterAssignment [3].gameObject.name);

		print ("rt 1 = " + rightThrusterAssignment [0].gameObject.name);
		print ("rt 2 = " + rightThrusterAssignment [1].gameObject.name);
		print ("rt 3 = " + rightThrusterAssignment [2].gameObject.name);
		print ("rt 4 = " + rightThrusterAssignment [3].gameObject.name);
	}
	
	// Update is called once per frame
	void Update ()
	{
		leftThrusterAssignment [0].thrust_1 = InputManager.pl_Controller.leftTrigger;
		rightThrusterAssignment [0].thrust_2 = InputManager.pl_Controller.rightTrigger;

		leftThrusterAssignment [1].thrust_1 = InputManager.p2_Controller.leftTrigger;
		rightThrusterAssignment [1].thrust_2 = InputManager.p2_Controller.rightTrigger;

		leftThrusterAssignment [2].thrust_1 = InputManager.p3_Controller.leftTrigger;
		rightThrusterAssignment [2].thrust_2 = InputManager.p3_Controller.rightTrigger;

		leftThrusterAssignment [3].thrust_1 = InputManager.p4_Controller.leftTrigger;
		rightThrusterAssignment [3].thrust_2 = InputManager.p4_Controller.rightTrigger;

	}

	void AssignInitialThrusters()
	{
		leftThrusterAssignment.Add (frontThruster);
		leftThrusterAssignment.Add (backThruster);
		leftThrusterAssignment.Add (leftThruster);
		leftThrusterAssignment.Add (rightThruster);

		rightThrusterAssignment.Add (frontThruster);
		rightThrusterAssignment.Add (backThruster);
		rightThrusterAssignment.Add (leftThruster);
		rightThrusterAssignment.Add (rightThruster);

		ShuffleThrusterList (leftThrusterAssignment);
		ShuffleThrusterList (rightThrusterAssignment);

	}

	void ShuffleThrusterList(List<Thruster> listToShuffle)
	{
		int n = listToShuffle.Count;
		for (int i = 0; i < n; i++) 
		{
			int r = i + (int)(Random.Range(0, 1f) * (n-i));
			Thruster t = listToShuffle[r];
			listToShuffle[r] = listToShuffle[i];
			listToShuffle[i] = t;
		}
	}
}

/*
static void Shuffle<T>(T[] array)
{
	int n = array.Length;
	for (int i = 0; i < n; i++)
	{
		// NextDouble returns a random number between 0 and 1.
		// ... It is equivalent to Math.random() in Java.
		int r = i + (int)(_random.NextDouble() * (n - i));
		T t = array[r];
		array[r] = array[i];
		array[i] = t;
	}
}*/
