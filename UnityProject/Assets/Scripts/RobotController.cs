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

		ShuffleThrusterList (leftThrusterAssignment, rightThrusterAssignment);
		ShuffleThrusterList (rightThrusterAssignment, leftThrusterAssignment);

	}

	void ShuffleThrusterList(List<Thruster> listToShuffle, List<Thruster> otherList)
	{
		int n = listToShuffle.Count;
		for (int i = 0; i < n; i++) 
		{
			int r = i + (int)(Random.Range(0, 1f) * (n-i));
			Thruster t = listToShuffle[r];
			listToShuffle[r] = listToShuffle[i];
			listToShuffle[i] = t;
		}
		PerformComparisonCheck (listToShuffle, otherList);
	}

	void PerformComparisonCheck(List<Thruster> shufflingList, List<Thruster> otherList)
	{
		if (shufflingList [0] == otherList [0])
		{
			if (shufflingList [1] != otherList[0])
			{
				Thruster tempThruster = shufflingList[1];
				shufflingList[1] = shufflingList[0];
				shufflingList[0] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[2];
				shufflingList[2] = shufflingList[0];
				shufflingList[0] = tempThruster;
			}
		}

		if (shufflingList [1] == otherList [1])
		{
			if (shufflingList [2] != otherList[1])
			{
				Thruster tempThruster = shufflingList[1];
				shufflingList[2] = shufflingList[1];
				shufflingList[1] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[3];
				shufflingList[3] = shufflingList[1];
				shufflingList[1] = tempThruster;
			}
		}

		if (shufflingList [2] == otherList [2])
		{
			if (shufflingList [3] != otherList[2])
			{
				Thruster tempThruster = shufflingList[3];
				shufflingList[3] = shufflingList[2];
				shufflingList[2] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[0];
				shufflingList[0] = shufflingList[2];
				shufflingList[2] = tempThruster;
			}
		}

		if (shufflingList [3] == otherList [3])
		{
			if (shufflingList [0] != otherList[3])
			{
				Thruster tempThruster = shufflingList[0];
				shufflingList[0] = shufflingList[3];
				shufflingList[3] = tempThruster;
			}
			else
			{
				Thruster tempThruster = shufflingList[1];
				shufflingList[1] = shufflingList[3];
				shufflingList[3] = tempThruster;
			}
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
